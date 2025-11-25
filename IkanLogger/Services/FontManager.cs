using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace IkanLogger.Services
{
    public static class FontManager
    {
        private static PrivateFontCollection pfc = new PrivateFontCollection();
        private static bool isLoaded = false;

        // Dictionary untuk mapping nama file ke index family
        private static Dictionary<string, int> fontMapping = new Dictionary<string, int>();

        public static Font Get(string fontFileName, float size, FontStyle style = FontStyle.Regular)
        {
            if (!isLoaded)
                LoadAllFonts();

            if (pfc.Families.Length == 0)
            {
                return new Font("Arial", size, style);
            }

            string key = Path.GetFileNameWithoutExtension(fontFileName).ToLower();

            // Cek di mapping dulu
            if (fontMapping.ContainsKey(key))
            {
                return new Font(pfc.Families[fontMapping[key]], size, style);
            }

            // Cari dengan nama family
            foreach (var family in pfc.Families)
            {
                if (family.Name.Contains(key, StringComparison.OrdinalIgnoreCase))
                {
                    return new Font(family, size, style);
                }
            }

            // Fallback ke font pertama
            return new Font(pfc.Families[0], size, style);
        }

        private static void LoadAllFonts()
        {
            var asm = Assembly.GetExecutingAssembly();
            var resources = asm.GetManifestResourceNames();

            int fontIndex = 0;

            foreach (string res in resources)
            {
                if (res.EndsWith(".otf", StringComparison.OrdinalIgnoreCase) ||
                    res.EndsWith(".ttf", StringComparison.OrdinalIgnoreCase))
                {
                    using Stream stream = asm.GetManifestResourceStream(res);
                    if (stream == null) continue;

                    byte[] data = new byte[stream.Length];
                    stream.Read(data, 0, data.Length);

                    IntPtr ptr = Marshal.AllocCoTaskMem(data.Length);
                    Marshal.Copy(data, 0, ptr, data.Length);

                    pfc.AddMemoryFont(ptr, data.Length);
                    Marshal.FreeCoTaskMem(ptr);

                    // Ambil nama file dari resource name
                    // Contoh: "IkanLogger.Resources.Font.MAUIKEA_Demo.otf" 
                    // → ambil "MAUIKEA_Demo"
                    string[] parts = res.Split('.');
                    if (parts.Length >= 2)
                    {
                        // Ambil part sebelum extension (.otf/.ttf)
                        string fileNamePart = parts[parts.Length - 2];
                        string key = fileNamePart.ToLower().Replace("_", " ").Replace("-", " ");

                        fontMapping[key] = fontIndex;

                        // Juga simpan versi tanpa spasi
                        fontMapping[fileNamePart.ToLower()] = fontIndex;
                    }

                    fontIndex++;
                }
            }

            isLoaded = true;
        }

        // Method untuk debugging - lihat semua font yang berhasil dimuat
        public static string GetDebugInfo()
        {
            var sb = new StringBuilder();
            var asm = Assembly.GetExecutingAssembly();
            var resources = asm.GetManifestResourceNames();

            sb.AppendLine("=== EMBEDDED RESOURCES ===");
            foreach (string res in resources)
            {
                if (res.EndsWith(".otf", StringComparison.OrdinalIgnoreCase) ||
                    res.EndsWith(".ttf", StringComparison.OrdinalIgnoreCase))
                {
                    sb.AppendLine($"✓ {res}");
                }
            }

            if (!isLoaded)
                LoadAllFonts();

            sb.AppendLine("\n=== LOADED FONTS ===");
            sb.AppendLine($"Total families loaded: {pfc.Families.Length}");

            for (int i = 0; i < pfc.Families.Length; i++)
            {
                sb.AppendLine($"[{i}] Family Name: '{pfc.Families[i].Name}'");
            }

            sb.AppendLine("\n=== FONT MAPPING ===");
            foreach (var kvp in fontMapping)
            {
                if (kvp.Value < pfc.Families.Length)
                {
                    sb.AppendLine($"'{kvp.Key}' -> Family[{kvp.Value}]: '{pfc.Families[kvp.Value].Name}'");
                }
            }

            return sb.ToString();
        }

        // Method alternatif - ambil berdasarkan nama font family langsung
        public static Font GetByFamilyName(string familyName, float size, FontStyle style = FontStyle.Regular)
        {
            if (!isLoaded)
                LoadAllFonts();

            foreach (var family in pfc.Families)
            {
                if (family.Name.Equals(familyName, StringComparison.OrdinalIgnoreCase))
                {
                    return new Font(family, size, style);
                }
            }

            return new Font("Arial", size, style);
        }
    }
}
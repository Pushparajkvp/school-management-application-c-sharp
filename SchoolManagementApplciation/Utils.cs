using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SchoolManagementApplciation
{
    class Utils
    {
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);

        public static Icon GetIcon(Bitmap bitmap)
        {
            IntPtr Hicon = bitmap.GetHicon();
            Icon newIcon = Icon.FromHandle(Hicon);
            return newIcon;
        }

        public static MainInterface GetMainInterface()
        {
            return (MainInterface)Application.OpenForms["MainInterface"];
        }

        public static string SaveImageToApplicationFolder(string path)
        {
            string executablePath = Path.GetDirectoryName(Application.ExecutablePath);
            string directory = executablePath + "\\PicturesofStudent";
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            string newFileName = Path.GetFileNameWithoutExtension(path) +
                        DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss") +
                        Path.GetExtension(path);
            File.Copy(path, directory + "\\" + newFileName, false);
            return directory + "\\" + newFileName;
        }
        public static string SaveDocumentToApplicationFolder(string path)
        {
            string executablePath = Path.GetDirectoryName(Application.ExecutablePath);
            string directory = executablePath + "\\Documents";
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            string newFileName = Path.GetFileNameWithoutExtension(path) +
                        DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss") +
                        Path.GetExtension(path);
            File.Copy(path, directory + "\\" + newFileName, false);
            return directory + "\\" + newFileName;
        }
    }
    public static class ExternMethods
    {
       
        public static Type IsNumber(this object value)
        {
            if (value is sbyte)
                return typeof(sbyte);
            if (value is byte)
                return typeof(byte);
            if (value is short)
                return typeof(short);
            if (value is ushort)
                return typeof(ushort);
            if (value is int)
                return typeof(int);
            if (value is uint)
                return typeof(uint);
            if (value is long)
                return typeof(long);
            if (value is ulong)
                return typeof(ulong);
            if (value is float)
                return typeof(float);
            if (value is double)
                return typeof(double);
            if (value is decimal)
                return typeof(decimal);
            return null;
        }
        public static string ToMonthName(this DateTime dateTime)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dateTime.Month);
        }

        public static string ToShortMonthName(this DateTime dateTime)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(dateTime.Month);
        }
        
        public static void CreateOrShow(this Form form)
        {
            if (form.IsHandleCreated)
                form.Activate();
            else
                form.Show();
        }
    }
}

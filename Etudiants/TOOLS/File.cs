using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace TOOLS
{
    public class File
    {
        public static byte[] GetBytes(string FileName)
        {
            try
            {
                if(FileName !=null && System.IO.File.Exists(FileName))
                {
                    return System.IO.File.ReadAllBytes(FileName);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public static byte[] GetBytes(System.Drawing.Image Image,System.Drawing.Imaging.ImageFormat ImageFormat)
        {
            try
            {
                if (Image!=null)
                {
                    System.IO.MemoryStream MS = new MemoryStream();
                    Image.Save(MS, ImageFormat);
                    MS.Position = 0;
                    return MS.ToArray();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public static System.Drawing.Bitmap  GetImage(string FileName,int Width=0,int Height =0)
        {
            try
            {
                if (FileName != null && System.IO.File.Exists(FileName))
                {
                    var Image = System.Drawing.Image.FromFile(FileName, true);
                    return RedimImage(Image,Width,Height);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public static System.Drawing.Bitmap GetImage(string FileName, System.Drawing.Size Size)
        {
            try
            {
                if (FileName != null && System.IO.File.Exists(FileName))
                {
                    var Image = System.Drawing.Image.FromFile(FileName, true);
                    return RedimImage(Image, Size);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public static System.Drawing.Image  GetImage(System.IO.Stream Stream, int Width = 0, int Height = 0)
        {
            try
            {
                if (Stream != null)
                {
                    Stream.Position = 0;
                    var Image = System.Drawing.Image.FromStream(Stream , true);
                    return RedimImage(Image, Width, Height);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public static System.Drawing.Bitmap GetImage(System.IO.Stream Stream, System.Drawing.Size Size)
        {
            try
            {
                if (Stream  != null)
                {
                    Stream.Position = 0;
                    var Image = System.Drawing.Image.FromStream(Stream , true);
                    return RedimImage(Image, Size);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }


        public static System.Drawing.Bitmap GetImage(byte[] Array, int Width = 0, int Height = 0)
        {
            try
            {
                if (Array  != null)
                {
                    System.IO.MemoryStream MS = new MemoryStream(Array);
                    MS.Position = 0;
                    var Image = System.Drawing.Image.FromStream(MS, true);
                    return RedimImage(Image, Width,Height);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public static System.Drawing.Bitmap GetImage(byte[] Array, System.Drawing.Size Size)
        {
            try
            {
                if (Array  != null)
                {
                    MemoryStream MS = new MemoryStream(Array);
                    MS.Position = 0;
                    var Image = System.Drawing.Image.FromStream(MS, true);
                    return RedimImage(Image, Size);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public static System.Drawing.Bitmap RedimImage(System.Drawing.Image image, int Width,int Height)
        {
            try
            {
                System.Drawing.Bitmap Bitmap = new System.Drawing.Bitmap(image);
                double PW = 0;
                if (Width  != 0)
                {
                    PW = image.Width / Width;
                }

                double PH = image.Height / Height;

                if (Height  != 0)
                {
                    PH = image.Height  / Height ;
                }

                double P = (PW > PH) ? PW : PH;
                if (P > 1) 
                {
                    Bitmap = new System.Drawing.Bitmap(image, Convert.ToInt32(image.Width / P), Convert.ToInt32(image.Height / P));
                    using (System.Drawing.Graphics graphicshandle = System.Drawing.Graphics.FromImage(Bitmap))
                    {
                        graphicshandle.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        graphicshandle.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                        graphicshandle.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                        graphicshandle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        graphicshandle.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                        graphicshandle.DrawImage(Bitmap, 0, 0, Width, Height);
                    }
                
                }
                return Bitmap;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static System.Drawing.Bitmap RedimImage(System.Drawing.Image image,System.Drawing.Size Size)
        {
            try
            {
      
                return RedimImage(image,Size.Width,Size.Height);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public static System.IO.Stream  GetStream(string FileName)
        {
            System.IO.FileStream F = null;
            try
            {

                if (FileName != null && System.IO.File.Exists(FileName))
                {
                    F = new System.IO.FileStream(FileName, System.IO.FileMode.Open,FileAccess.ReadWrite,FileShare.ReadWrite );

                        F.Position = 0;
                        return F;                 
                   
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

                /*if (F != null)
                    F.Dispose();*/
            }
            
            return null;
        }


        public static string GetMimeType(string FileName)
        {
           
                if (FileName != null && System.IO.File.Exists(FileName)) 
                {
                    string Mime = "application/unknown";
                    string Ext = System.IO.Path.GetExtension(FileName).ToLower();
                    Microsoft.Win32.RegistryKey RegKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(Ext);
                    if (RegKey != null && RegKey.GetValue("Content Type") != null)
                        Mime = Convert.ToString(RegKey.GetValue("Content Type"));
                    return Mime;
                }
       
            return null;
        }

        public static string GetExtension(string FileName)
        {

            if (FileName != null && System.IO.File.Exists(FileName))
            {
                
                return System.IO.Path.GetExtension(FileName);
            }

            return null;
        }
        private static System.Collections.Concurrent.ConcurrentDictionary<string , string > MimeTypeToExtension =new System.Collections.Concurrent.ConcurrentDictionary<string, string>();
        private static System.Collections.Concurrent.ConcurrentDictionary<string, string> ExtensionToMimeType = new System.Collections.Concurrent.ConcurrentDictionary<string, string>();


        public static string GetExtensionWidthMimeType(string MimeType)
        {

            if (!string.IsNullOrWhiteSpace(MimeType))
            {
                string key   = string.Format("MIME\\Database\\Content Type\\{0}", MimeType);
                string result  = null;
            if (MimeTypeToExtension.TryGetValue(key,out result))
            {
               return result;
            }

            Microsoft.Win32.RegistryKey regKey; 
            object value;

            regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(key, false);
                value = (regKey != null)? regKey.GetValue("Extension", null): null;
                result = (value !=null)?Convert.ToString(value): string.Empty ;

            MimeTypeToExtension[key]=Convert.ToString(result);
            return result;
            }

            return null;
        }


        public static string GetExtensionWidthExtension(string Extension)
        {

            if (!string.IsNullOrWhiteSpace(Extension))
            {
                if (!Extension.StartsWith("."))
                    Extension = "." + Extension;
       
                string result = null;
                if (ExtensionToMimeType.TryGetValue(Extension , out result))
                {
                    return result;
                }

                Microsoft.Win32.RegistryKey regKey;
                object value;

                regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(Extension , false);
                value = (regKey != null) ? regKey.GetValue("Content Type", null) : null;
                result = (value != null) ? Convert.ToString(value) : string.Empty;

                MimeTypeToExtension[Extension] = Convert.ToString(result);
                return result;
            }

            return null;
        }
    }
}

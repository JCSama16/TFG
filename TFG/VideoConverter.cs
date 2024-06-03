using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Lame;
using System.IO;


namespace TFG
{
    internal class VideoConverter
    {
        public void ConvertToMp3(string videoFilePath, string mp3FilePath)
        {
            try
            {
                using (var reader = new MediaFoundationReader(videoFilePath))
                {
                    // Mantiene el formato de audio original del archivo de vídeo
                    var outputFormat = reader.WaveFormat;

                    // Crea un archivo de salida MP3 con el mejor formato
                    using (var outputStream = File.Create(mp3FilePath))
                    {
                        // Configura el LameMP3FileWriter para usar la mejor calidad
                        using (var writer = new LameMP3FileWriter(outputStream, outputFormat, 320))
                        {
                            // Copia el audio del archivo de vídeo al archivo MP3
                            reader.CopyTo(writer);
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException("Acceso denegado. Por favor, selecciona una ruta de salida donde tengas permisos de escritura.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error durante la conversión: " + ex.Message, ex);
            }
        }
    }
}

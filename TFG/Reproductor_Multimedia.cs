using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibVLCSharp;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;

namespace TFG
{
    internal class Reproductor_Multimedia
    {
        private LibVLC _libVLC;
        private LibVLCSharp.Shared.MediaPlayer _mediaPlayer;
        private VideoView _videoView;

        public Reproductor_Multimedia()
        {
            Core.Initialize();

            _libVLC = new LibVLC();
            _mediaPlayer = new LibVLCSharp.Shared.MediaPlayer(_libVLC);
        }

        public void ConfigureVideoView(VideoView videoView)
        {
            _videoView = videoView;
            _videoView.MediaPlayer = _mediaPlayer;
            Console.WriteLine("VideoView configurado con MediaPlayer.");
        }

        public LibVLCSharp.Shared.MediaPlayer GetMediaPlayer()
        {
            return _mediaPlayer;
        }

        public void PlayVideo(string videoPath)
        {
            var media = new Media(_libVLC, new Uri(videoPath));
            if (_mediaPlayer.Play(media))
            {
                Console.WriteLine("Reproducción iniciada: " + videoPath);
            }
            else
            {
                Console.WriteLine("Error al iniciar la reproducción: " + videoPath);
            }

        }

        public void PauseVideo()
        {
            
            _mediaPlayer.Pause();
            
        }

        public void StopVideo()
        {
            _mediaPlayer.Stop();
        }


        public void Dispose()
        {
            _mediaPlayer.Dispose();
            _libVLC.Dispose();
        }
    }
}

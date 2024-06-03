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

        public Reproductor_Multimedia()
        {
            Core.Initialize();

            _libVLC = new LibVLC();
            _mediaPlayer = new LibVLCSharp.Shared.MediaPlayer(_libVLC);
        }

        public void ConfigureVideoView(VideoView videoView)
        {
            videoView.MediaPlayer = _mediaPlayer;
        }

        public void PlayVideo(string videoPath)
        {
            var media = new Media(_libVLC, new Uri(videoPath));
            _mediaPlayer.Play(media);
        }

        public void PauseVideo()
        {
            if (_mediaPlayer.IsPlaying)
            {
                _mediaPlayer.Pause();
            }
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

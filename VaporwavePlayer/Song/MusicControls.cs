using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using CSCore;
using CSCore.Codecs;
using CSCore.CoreAudioAPI;
using CSCore.SoundOut;

namespace VaporwavePlayer
{
    public class MusicControls
    {
        
        #region Private Members
        private ISoundOut _soundOut;
        private IWaveSource _waveSource;
        private static Random rng = new Random();

        #endregion

        #region Properties
        public PlaybackState PlaybackState => _soundOut?.PlaybackState ?? PlaybackState.Stopped;
        public TimeSpan MusicDuration => _waveSource?.GetPosition() ?? TimeSpan.Zero;
        public TimeSpan MusicLength => _waveSource?.GetLength() ?? TimeSpan.Zero;
        /// <summary>
        /// property for changing volume
        /// </summary>
        public int Volume
        {
            get => _soundOut != null ? Math.Min(100, Math.Max((int)(_soundOut.Volume * 100), 0)) : 20;
            set
            {
                if (_soundOut != null)
                {
                    _soundOut.Volume = Math.Min(1.0f, Math.Max(value / 100f, 0f));
                }
            }
        }


        #endregion

        #region Events

        public event EventHandler<PlaybackStoppedEventArgs> PlaybackStopped;
        #endregion
        #region Methods

        /// <summary>
        /// Opening songfile to play
        /// </summary>
        /// <param name="filename">name of file</param>
        /// <param name="device">automatically detects device to produce sound on</param>
        public void Open(string filename, MMDevice device)
        {
            CleanupPlayback();

            _waveSource =
                CodecFactory.Instance.GetCodec(filename)
                    .ToSampleSource()
                    .ToMono()
                    .ToWaveSource();
            _soundOut = new WasapiOut() {Latency = 100, Device = device};
            _soundOut.Initialize(_waveSource);
            if (PlaybackStopped != null) _soundOut.Stopped += PlaybackStopped;
        }
       /// <summary>
       /// Shuffle the PlayBack order
       /// </summary>
       /// <param name="order">songs order</param>
       public static void Shuffle(IList<Song> order)
       {
            foreach (var songs in order)
            {
                songs.Id = rng.Next() % order.Count;
            }


        }
       /// <summary>
       /// Playing music
       /// </summary>
        public void Play()
        {
            _soundOut?.Play();
        }
        /// <summary>
        /// Stop music
        /// </summary>
        public void Stop()
        {
            _soundOut?.Stop();
        }
        /// <summary>
        /// Pause while playing
        /// </summary>
        public void Pause()
        {
            _soundOut?.Pause();
        }

        /// <summary>
        /// Cleaning the order
        /// </summary>
        private void CleanupPlayback()
        {
            if (_soundOut != null)
            {
                _soundOut.Dispose();
                _soundOut = null;
            }

            if (_waveSource != null)
            {
                _waveSource.Dispose();
                _waveSource = null;
            }
        }

        
        #endregion
    }
}

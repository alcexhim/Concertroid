using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UniversalEditor;
using UniversalEditor.ObjectModels.Multimedia.Audio.Waveform;

namespace Concertroid.Renderer
{
    public class AudioManager
    {
        private Surodoine.AudioStream mvarAudioStream = new Surodoine.AudioStream();

        private WaveformAudioObjectModel mvarWaveform = new WaveformAudioObjectModel();
        private bool mvarFadingOut = false;

        static AudioManager()
        {
            Surodoine.AudioEngine.Initialize();
        }

        private int mvarFadeSpeed = 2048;
        public int FadeSpeed { get { return mvarFadeSpeed; } set { mvarFadeSpeed = value; } }

        private System.Threading.Thread _thread = null;
        private void _thread_ThreadStart()
        {
            int i = 0;
            double vol = 1.0;

            mvarAudioStream = new Surodoine.AudioStream(mvarWaveform.Header.SampleRate * mvarWaveform.Header.ChannelCount);
            while (true)
            {
                short l = mvarWaveform.RawSamples[i];
                short r = mvarWaveform.RawSamples[i + 1];

                short L = (short)((double)l * vol);
                short R = (short)((double)r * vol);

                mvarAudioStream.Write(new short[] {L, R});
                i += mvarWaveform.Header.ChannelCount;
                if (i >= mvarWaveform.RawSamples.Length)
                {
                    i = 0;
                }

                if (mvarFadingOut)
                {
                    if ((i % mvarFadeSpeed) == 0)
                    {
                        vol = (vol - 0.01);
                    }
                }
                if (vol <= 0.0)
                {
                    break;
                }

                // mvarFadingOut = true;
            }
        }

        public bool IsPlaying { get { return (_thread != null && _thread.IsAlive); } }

        public void Load(string FileName)
        {
            mvarWaveform = UniversalEditor.Common.Reflection.GetAvailableObjectModel<WaveformAudioObjectModel>(FileName);
        }
        public void Play()
        {
            if (_thread == null) _thread = new System.Threading.Thread(_thread_ThreadStart);
            _thread.Start();
        }
        public void Stop()
        {
            if (_thread != null) _thread.Abort();
            _thread = null;
        }
        public void FadeOut()
        {
            if (_thread != null) mvarFadingOut = true;
        }
    }
}

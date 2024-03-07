using Speaker.leison.Sistem.layer.Interfaces;
using System;
using System.Speech.Synthesis;
using System.Threading.Tasks;

namespace Sistem.layer.Repositories
{
    public class SoundRepository: ISoundRepository
    {

        public async Task SpeakNow(string text)
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                foreach (InstalledVoice voice in synth.GetInstalledVoices())
                {
                    VoiceInfo info = voice.VoiceInfo;
                    if (info.Culture.Name.StartsWith("ka-GE"))
                    {
                        synth.SelectVoice(info.Name);
                        break;
                    }
                }
                await Task.Run(() =>
                {
                    try
                    {
                        synth.Speak(text);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("shecdoma saubris dros" + ex.Message);
                    }
                });
                await Task.Delay(300);
            }
        }
    }
}

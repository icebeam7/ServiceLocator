using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ServiceLocator
{
	public partial class TextToSpeechPage : ContentPage
	{
		public TextToSpeechPage ()
		{
			InitializeComponent ();
		}

        void btnSpeak_Clicked(object sender, EventArgs e)
        {
            ITextToSpeech tts = Locator.Instance.Resolve<ITextToSpeech>();

            if (tts != null)
            {
                string text = "Hello world.";
                tts.Speak(text);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocator
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}

using System;

namespace GiftTasteHelper
{
    public interface IStardewAccessApi
    {
        public string PrevMenuQueryText
        {
            get;
            set;
        }

        public string MenuPrefixText
        {
            get;
            set;
        }

        public string MenuSuffixText
        {
            get;
            set;
        }

        /// <summary>Speaks the text via the loaded screen reader (if any).</summary>
        /// <param name="text">The text to be narrated.</param>
        /// <param name="interrupt">Whether to skip the currently speaking text or not.</param>
        public void Say(String text, Boolean interrupt);

        /// <summary>Speaks the text via the loaded screen reader (if any).
        /// <br/>Skips the text narration if the previously narrated text was the same as the one provided.
        /// <br/><br/>Use this when narrating hovered component in menus to avoid interference.</summary>
        /// <param name="text">The text to be narrated.</param>
        /// <param name="interrupt">Whether to skip the currently speaking text or not.</param>
        public void SayWithMenuChecker(String text, Boolean interrupt);

    }
}

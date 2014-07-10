namespace WeckerApp
{
    using WMPLib;

    class Sound
    {
        public void Play()
        {
            this.StartMp3(@"D:\Projects\GitHub\ThomasDeboben\WeckerApp\WeckerApp\salamisound-4958330-klassischer-wecker-klingelt.mp3");
        }

        private void StartMp3(string soundfile)
        {
            var wplayer = new WindowsMediaPlayer { URL = soundfile };
        }
    }
}

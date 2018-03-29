namespace Yunlin.Culture.Video.Service
{
    using System.Text;

    public class NamingRuleService
    {
        public int TestFunction(int index)
        {
            switch (index) {
                case 1: break;
                default: break;
            }

            if (index == 0) {
                this.DoTrue();
            }
            else {
                this.DoFalse();
            }

            if (this.DoTrue()) {
                this.DoTrue();
            }

            return index * (index + 1) / 2;
        }

        public void TestStringFunction(string value)
        {
            var newString = "ABCDEFG"; // 新字串

            // if ((value != null) | (value != string.Empty)) // 永遠為true
            // value = newString.Replace("A", ",").Replace("B", "_").Replace("C", " ");
            if (true) {
                value = new StringBuilder(newString).Replace("A", ",").Replace("B", "_").Replace("C", " ").ToString();
            }
        }

        private bool DoFalse()
        {
            return false;
        }

        private bool DoTrue()
        {
            return true;
        }
    }
}
using System.Windows.Forms;

namespace EstimationSuite.Custom
{
    public class CheckedItem<T>
    {
        public CheckState State { get; set; }

        public T Item { get; set; }

        public override string ToString()
        {
            return Item.ToString();
        }
    }
}
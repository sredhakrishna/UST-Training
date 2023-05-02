namespace Indexers
{
    public class array
    {
        float[] arr = new float[] { 12.3f, 34.7f, 44.6f };
        public float this[int index]
        {
            get 
            { 
            return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }

    }
}
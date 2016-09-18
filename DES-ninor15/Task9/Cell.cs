namespace DES_ninor15.Task9
{
    public class Cell
    {
        public bool IsAlive { get; set; }

        public void Kill()
        {
            IsAlive = false;
        }

        public void Revive()
        {
            IsAlive = true;
        }

        public bool GetStatusForNeighborCount(int count)
        {
            if (IsAlive)
            {
                if (count < 2)
                {
                    return false;
                }
                else if (count < 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (count == 3)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
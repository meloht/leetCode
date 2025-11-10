using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace leetCode._1101_1150
{
    public class _1117_BuildingH2OAlg
    {
        public class H2O
        {
            public System.Threading.SemaphoreSlim semO = new(0, 1); 
            public System.Threading.SemaphoreSlim semH = new(2, 2);

            public H2O()
            {

            }

            public void Hydrogen(Action releaseHydrogen)
            {
                semH.Wait();
                releaseHydrogen();
                if (semH.CurrentCount == 0)
                {
                    semO.Release();
                }
            }

            public void Oxygen(Action releaseOxygen)
            {
                semO.Wait();
                releaseOxygen(); // releaseOxygen() outputs "O". Do not change or remove this line.
                semH.Release(2); 
            }
        }
    }
}

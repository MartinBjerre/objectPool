using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Object_pool
{
    public class Pool
    {
        private static List<PoolObject> _available = new List<PoolObject>(); 
        private  static List<PoolObject> _inUse = new List<PoolObject>();

        public static PoolObject GetPoolObject()
        {
            lock (_available)
            {
                if (_available.Count != 0)
                {
                    PoolObject po = _available[0];
                    _inUse.Add(po);
                    _available.RemoveAt(0);
                    return po;
                }
                else
                {
                    PoolObject po = new PoolObject();
                    _inUse.Add(po);
                    return po;
                }
            }
        }

        public static void ReleaseObject(PoolObject po)
        {
            CleanUp(po);
            lock (_available)
            {
                _available.Add(po);
                _inUse.Remove(po);
            }
        }

        private static void CleanUp(PoolObject po)
        {
            po.TempData = null;
        }
    }
}
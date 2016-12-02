using System;

namespace Object_pool
{
    public class PoolObject
    {
        DateTime _CreateAt = DateTime.Now;

        public DateTime CreateAt
        {
            get { return _CreateAt; }
        }
        public string TempData { get; set; }
    }
}
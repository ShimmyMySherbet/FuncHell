﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncHell.Models
{
    public delegate Func<Func<Func<Func<Func<Func<Func<Func<Func<Func<Func<Func<Func<Func<Func<Func<T>>>>>>>>>>>>>>>> L1<T>();
    public delegate L1<L1<L1<L1<L1<L1<L1<L1<L1<L1<L1<L1<L1<L1<L1<L1<L1<L1<L1<L1<L1<L1<T>>>>>>>>>>>>>>>>>>>>>> L2<T>();
    public delegate L2<L2<L2<L2<L2<L2<L2<L2<L2<L2<L2<L2<L2<L2<L2<L2<L2<L2<L2<L2<L2<L2<T>>>>>>>>>>>>>>>>>>>>>> L3<T>();
    public delegate L3<L3<L3<L3<L3<L3<L3<L3<L3<L3<L3<L3<L3<L3<L3<L3<L3<L3<L3<L3<L3<L3<T>>>>>>>>>>>>>>>>>>>>>> L4<T>();
    public delegate L4<L4<L4<L4<L4<L4<L4<L4<L4<L4<L4<L4<L4<L4<L4<L4<L4<L4<L4<L4<L4<L4<T>>>>>>>>>>>>>>>>>>>>>> L5<T>();
}

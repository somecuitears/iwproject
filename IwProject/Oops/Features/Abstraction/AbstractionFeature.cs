using System;
using System.Collections.Generic;
using System.Text;

namespace IwProject.Oops.Features
{
    //Abstract Class should contain common type of data. {Name,Address,Birthday are common so can be in abstract class}
    public abstract class AbstractionFeature
    {
        abstract public void MethodOne();
        abstract public void MethodTwo();
    }

    public abstract class SecondAbstractionFeature
    {
        abstract public void SecondMethodOne();
        abstract public void SecondMethodTwo();

    }
}

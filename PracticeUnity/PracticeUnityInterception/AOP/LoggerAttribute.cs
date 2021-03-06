﻿using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace PracticeUnityInterception
{
  internal class LoggerAttribute : HandlerAttribute
  {
    public override ICallHandler CreateHandler(IUnityContainer container)
    {
      return new LoggerCallHandler();
    }
  }
}

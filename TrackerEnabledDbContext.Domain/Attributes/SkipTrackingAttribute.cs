namespace System.ComponentModel.DataAnnotations
{
  using System;

  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
  public class SkipTrackingAttribute : Attribute
  {
  }
}

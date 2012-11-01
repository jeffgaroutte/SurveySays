using System;
namespace SurveySays.Domain.Models
{
    public interface IPreRequsite
    {
        bool IsSatisfied();
    }
}

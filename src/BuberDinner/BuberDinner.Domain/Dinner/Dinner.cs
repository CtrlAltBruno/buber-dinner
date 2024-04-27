using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Dinner.ValueObjects;

namespace BuberDinner.Domain.Dinner;

public sealed class Dinner(DinnerId id) : AggregateRoot<DinnerId>(id)
{

}
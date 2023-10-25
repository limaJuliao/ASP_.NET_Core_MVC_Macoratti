using System;
using System.ComponentModel.DataAnnotations;

namespace Lanches.Domain.Entities;

public abstract class BaseEntity
{
    [Key]
    public int Id { get; private set; }
}
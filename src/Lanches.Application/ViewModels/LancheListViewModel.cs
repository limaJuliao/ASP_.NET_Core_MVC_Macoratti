﻿using Lanches.Domain.Entities;

namespace Lanches.Application.ViewModels;

public class LancheListViewModel
{
    public IEnumerable<Lanche> Lanches { get; set; }
    public string CategoriaAtual { get; set; }

}

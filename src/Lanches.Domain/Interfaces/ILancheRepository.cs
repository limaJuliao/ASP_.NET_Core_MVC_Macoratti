using Lanches.Domain.Entities;

namespace Lanches.Domain.Interfaces;

public interface ILancheRepository
{
    IEnumerable<Lanche> Lanches { get; }
    IEnumerable<Lanche> LanchesPreferidos { get; }
    Lanche GetById(int id);
}

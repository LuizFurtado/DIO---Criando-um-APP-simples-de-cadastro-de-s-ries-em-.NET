using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
  public class SerieRepositorio : IRepositorio<Serie>
  {
    private List<Serie> listaSerie = new List<Serie>();

    public void Atualiza(int id, Serie entidade)
    {
      listaSerie[id] = entidade;
    }

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public void Exclui(int id)
    {
      listaSerie[id].excluir();
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public void Insere(Serie entidade)
    {
      listaSerie.Add(entidade);
    }

    public List<Serie> Lista()
    {
      return listaSerie;
    }

    public int ProximoId()
    {
      return listaSerie.Count;
    }

    public Serie RetornaPorId(int id)
    {
      return listaSerie[id];
    }

    public override string ToString()
    {
      return base.ToString();
    }
  }
}
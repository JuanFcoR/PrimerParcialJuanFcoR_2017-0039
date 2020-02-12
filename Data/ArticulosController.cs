using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PrimerParcialJuanFcoR_2017_0039.Data
{
	public class ArticulosController
	{

		public static bool Guardar(Articulos articulo)
		{
			bool paso = false;
			Contexto DataBase = new Contexto();
			try
			{
				DataBase.Add(articulo);

				if (DataBase.SaveChanges() > 0)
				{
					paso = true;
				}


			}
			catch (Exception)
			{

				throw;
			}

			return paso;
		}

		public static bool Modificar(Articulos articulo)
		{
			bool paso = false;
			Contexto DataBase = new Contexto();
			try
			{
				DataBase.Entry(articulo).State = EntityState.Modified;

				if (DataBase.SaveChanges() > 0)
				{
					paso = true;
				}


			}
			catch (Exception)
			{

				throw;
			}

			return paso;
		}

		public static Articulos Buscar(int Id)
		{
			Articulos articulos;
			Contexto DataBase = new Contexto();
			try
			{

				articulos = DataBase.Articulos.Find(Id);

			}
			catch (Exception)
			{

				throw;
			}

			return articulos;
		}

		public static bool Eliminar(int Id)
		{
			Articulos articulos;
			bool paso = false;
			Contexto DataBase = new Contexto();
			try
			{
				articulos = DataBase.Articulos.Find(Id);
				DataBase.Articulos.Remove(articulos);

				if (DataBase.SaveChanges() > 0)
				{
					paso = true;
				}


			}
			catch (Exception)
			{

				throw;
			}

			return paso;
		}

		public static List<Articulos> GetList(Expression<Func<Articulos,bool>>expression)
		{
			Contexto contexto = new Contexto();
			List<Articulos> Lista = new List<Articulos>();
			try
			{
				Lista =contexto.Articulos.Where(p=>true).ToList();
			}
			catch (Exception)
			{

				throw;
			}
			return Lista;
		}

	}




}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FilmesCRUDRazor.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FilmesCRUDRazor.Pages.Filmes
{
    public class IndexModel : PageModel
    {
        private readonly FilmesCRUDRazor.Models.FilmeContext _context;

        public IndexModel(FilmesCRUDRazor.Models.FilmeContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get;set; }

        public SelectList Generos;

        public string FilmePorGenero { get; set;}

        public async Task OnGetAsync(string buscaPorGeneroNome, string filmePorGenero)
        {
            #region Lógica do input

            IQueryable<string> queryGenero = from f in _context.Filme
                                             orderby f.Genero
                                             select f.Genero; 

            var filmes = from f in _context.Filme
                         select f; /* select * from Filme */
            
            if(!String.IsNullOrEmpty(buscaPorGeneroNome))
            {
                filmes = filmes.Where(b => b.Titulo.Contains(buscaPorGeneroNome));
            }
            #endregion

            #region Lógica do select
            if(!String.IsNullOrEmpty(filmePorGenero))
            {
                filmes = filmes.Where(b => b.Genero == filmePorGenero);
            }
            #endregion

            Generos = new SelectList(await queryGenero.Distinct().ToListAsync());                        
            Filme = await filmes.ToListAsync();
        }
    }
}

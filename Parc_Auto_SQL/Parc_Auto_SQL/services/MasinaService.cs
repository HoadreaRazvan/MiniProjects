using System;
using System.Collections.Generic;
using System.Text;
using App.exceptions;


namespace App.services
{
    public class MasinaService
    {
        public MasinaRepository control;

        public MasinaService()
        {
            this.control = new MasinaRepository();
        }

        public List<Masina> listaMasini()
        {
            return control.getAll();
        }

        public void create(Masina masina)
        {
            if (!this.listaMasini().Contains(masina))
            { 
                control.add(masina);
            }
            else
            {
                throw new MasinaExistsException("Masina introdusa exista");
            }
        }

        public void deleteById(int id)
        {
            if(this.listaMasini().Contains(this.control.getMasinaById(id)))
            {
                control.deleteById(id);
            }
            else
            {
                throw new MasinaExistsException("Masina introdusa nu exista");
            }
        }

        public void deleteByMarca(string marca)
        {
            Masina m = this.listaMasini().Find(e => e.Marca.Equals(marca));
            if (m != null)
            { 
                deleteById(m.Id);
            }
            else
            {
                throw new MasinaExistsException("Masina cu maraca" + marca + " nu exista");
            }     
        }

    }
}

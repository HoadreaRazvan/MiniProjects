using App;
using App.exceptions;
using App.services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class MasinaService_Tests
    {
        private readonly ITestOutputHelper outputHelper;
        private MasinaService service;

        public MasinaService_Tests(ITestOutputHelper output)
        {
            this.outputHelper = output;
            this.service = new MasinaService();
        }

        [Fact]

        public void adaugare_stergere()
        {
            Masina masina = new Masina("Dacia", "Logan", 321, 47);
            Masina masina1 = new Masina("TEST", "TEST1", 321, 47);

            Assert.Equal("Masina introdusa exista", Assert.Throws<MasinaExistsException>(() => service.create(masina)).Message);
 
            string marca = "dsa";
            Assert.Equal("Masina cu maraca" + marca + " nu exista", Assert.Throws<MasinaExistsException>(() => service.deleteByMarca(marca)).Message);

            this.service.create(masina1);
            Assert.True(this.service.listaMasini().Contains(masina1));
            this.service.deleteByMarca("TEST");
            Assert.False(this.service.listaMasini().Contains(masina1));
        }
    }
}

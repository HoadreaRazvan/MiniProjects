using DataAcces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace App
{
    public class MasinaRepository
    {
        private readonly string connectionString;
        private Data_Acces db;

        public MasinaRepository()
        {
            db = new Data_Acces();
            var builder = new ConfigurationBuilder().SetBasePath
            (@"D:\1_PROGRAMARE\C#\Baza_De_Date\Parc_Auto_Sql\Parc_Auto_SQL").AddJsonFile("appsettings.json");
            var config = builder.Build();
            this.connectionString = config.GetConnectionString("Default");
        }

        public List<Masina> getAll()
        {
            string sql = "select * from masina";
            return db.LoadData<Masina,dynamic>(sql,new { },connectionString);
        }

        public void add(Masina masina)
        {
            string sql = "insert into masina(marca,model,km,pret) values(@marca,@model,@km,@pret)";
            db.SaveData(sql, new { masina.Marca, masina.Model, masina.Km, masina.Pret }, connectionString);
        }

        public void deleteById(int id)
        {
            string sql = "delete from masina where id=@id";
            db.SaveData(sql, new { id }, connectionString);
        }

        public void updateMarcaById(int id, string marca)
        {
            string sql = "update masina set marca=@marca where id=@id";
            db.SaveData(sql, new { marca, id }, connectionString);
        }

        public void updatePretById(int id, int pret)
        {
            string sql = "update masina set pret=@pret where id=@id";
            db.SaveData(sql, new { pret, id }, connectionString);
        }

        public void updateKmById(int id, int km)
        {
            string sql = "update masina set km=@km where id=@id";
            db.SaveData(sql, new { km, id }, connectionString);
        }

        public void updateModelById(int id, string model)
        {
            string sql = "update masina set model=@model where id=@id";
            db.SaveData(sql, new { model, id }, connectionString);
        }


        public Masina getMasinaById(int id)
        {
            string sql = "select * from masina where id=@id";
            return db.LoadData<Masina, dynamic>(sql, new { id }, connectionString)[0];
        }

        public void deleteByMarca(string marca)
        {
            string sql = "delete from masina where marca=@marca";
            db.SaveData(sql, new { marca }, connectionString);
        }

        public Masina getMasinaByMarca(string marca)
        {
            string sql = "select * from masina where marca=@marca";
            return db.LoadData<Masina, dynamic>(sql, new { marca }, connectionString)[0];
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class BLL
    {
      public class Imagem
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Imagem", null);
            }
            static public object loadpic(int Numero_de_contribuinte)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte)
            
             };
                return dal.executarScalar("select Imagem from Imagem where @Numero_de_contribuinte=@Numero_de_contribuinte", sqlParams);

            }
          
            //Insere a imagem relativa ao numeroo de contribuinte
            static public int insertImagem(byte[] img,int Numero_de_contribuinte)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@img", img),
                 new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte)

           };

                return dal.executarNonQuery("INSERT into Imagem (Imagem,Numero_de_contribuinte) VALUES(@img,@Numero_de_contribuinte)", sqlParams);
            }
        }

        public class Alentejo
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Alentejo", null);
            }
            static public int insertAlentejo(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail,  string Contacto, string Nacionalidade,string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("INSERT into Alentejo (Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@e_mail,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
            }

            static public int updateAlentejo(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade,string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                     new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("update [Alentejo] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }
        }
            public class Algarve
            {
                static public DataTable Load()
                {
                    DAL dal = new DAL();
                    return dal.executarReader("select * from Algarve", null);
                }
                static public int insertAlgarve(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                    return dal.executarNonQuery("INSERT into Algarve(Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@e_mail,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
                }
                static public int updateAlgarve(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                         new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                    return dal.executarNonQuery("update [Algarve] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }
            }
            public class Almada
            {
                static public DataTable Load()
                {
                    DAL dal = new DAL();
                    return dal.executarReader("select * from Almada", null);
                }
                static public int insertAlmada(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail,string Contacto, string Nacionalidade, string Habilitacoes_literarias)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                    return dal.executarNonQuery("INSERT into Almada (Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@e_mail,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
                }
                static public int updateAlmada(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                         new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                    return dal.executarNonQuery("update [Almada] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }
            }
            public class Braga
            {
                static public DataTable Load()
                {
                    DAL dal = new DAL();
                    return dal.executarReader("select * from Braga", null);
                }
                static public int insetBraga(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                    return dal.executarNonQuery("INSERT into Braga (Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@e_mail,@data_de_nascimento,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
                }
                static public int updateBraga(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                         new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                    return dal.executarNonQuery("update [Braga] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }
            }
            public class Cascais
            {
                static public DataTable Load()
                {
                    DAL dal = new DAL();
                    return dal.executarReader("select * from Cascais", null);
                }
                static public int insertCascais(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                    return dal.executarNonQuery("INSERT into Cascais (Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@e_mail,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
                }
                static public int updatetCascais(int Id, string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail,  string Contacto, string Nacionalidade, string Habilitacoes_literarias)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                         new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                    return dal.executarNonQuery("update [Cascais] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }
            }

            public class Castelo_Branco
            {
                static public DataTable Load()
                {
                    DAL dal = new DAL();
                    return dal.executarReader("select * from CasteloBranco", null);
                }
                static public int insertCastelo_branco(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                    return dal.executarNonQuery("INSERT into CasteloBranco (Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@e_mail,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
                }
                static public int updateCastelo_branco(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                         new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                    return dal.executarNonQuery("update [CasteloBranco] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }
            }

            public class Coimbra
            {
                static public DataTable Load()
                {
                    DAL dal = new DAL();
                    return dal.executarReader("select * from Coimbra", null);
                }
                static public int insertCoimbra(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                    return dal.executarNonQuery("INSERT into Coimbra(Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@e_mail,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
                }
            
            static public int updateCoimbra(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                     new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("update [Coimbra] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }
        }

        public class Covilha
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Covilha", null);
            }
            static public int insertCovilha(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("INSERT into Covilha (Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@e_mail,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
            }
        
        static public int updateCovilha(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail,string Contacto, string Nacionalidade, string Habilitacoes_literarias)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]{
                 new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
            return dal.executarNonQuery("update [Covilha] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }

        }

        public class Évora
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Évora", null);
            }
            static public int insertevora(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("INSERT into Évora (Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@e_mail,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
            }



            static public int updateEvora(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail,string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                     new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("update [Évora] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }
        }


        public class Funchal
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Funchal", null);
            }
            static public int insertFunchal(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("INSERT into Funchal (Nome,Numero_de_contribuinte,Data_de_nascimento,E_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@e_mail,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
            }

            static public int updateFunchal(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                  
                     new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("update [Funchal] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }
        }

        public class Lisboa
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Lisboa", null);
            }
            static public int insertLisboa(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("INSERT into  Lisboa(Nome,Numero_de_contribuinte,e_mail,data_de_nascimento,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@e_mail,@data_de_nascimento,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
            }
            static public int updateLisboa(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail,string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                     new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("update [Lisboa] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }
        }

        public class Odivelas_Loures
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from OdivelasLoures", null);
            }
            static public int insertOdivelas_Loures(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("INSERT into  OdivelasLoures(Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@e_mail,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
            }
            static public int updateOdivelas_Loures(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail,string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                     new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade)
             };
                return dal.executarNonQuery("update [OdivelasLoures] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }
        }
        public class Oeiras
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Oeiras ", null);
            }
            static public int insertOeiras(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail,  string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("INSERT into Oeiras(Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@email,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
            }
            static public int UpdateOeiras(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                     new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("update [Oiras] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }
        }

        public class Porto
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Porto ", null);
            }
            static public int insertPorto(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("INSERT into Porto(Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@e_mail,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
            }
            static public int updatePorto(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                     new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("update [Porto] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }

        }
        public class Santarem
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Santarem ", null);
            }
            static public int insertSantarem(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("INSERT into Santarem(Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@e_mail,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
            }
            static public int updateSantarem(int Id, string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                     new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("update [Santarem] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }
        }

        public class Setubal
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Setubal ", null);
            }
            static public int insertSetubal(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("INSERT into Setubal(Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@email,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
            }
            static public int updateSetubal(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                     new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("update [Setubal] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }
        }

        public class Sintra
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Sintra ", null);
            }
            static public int insertSintra(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("INSERT into Sintra(Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@e_mail,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
            }
            static public int updateSintra(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail,string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                     new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("update [Sintra] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }
        }

        public class Viana_do_castelo
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from VianadoCastelo", null);
            }
            static public int insertvianadocastelo(string Nome, string Numero_de_contribuinte, string data_de_nascimento ,string e_mail,string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("INSERT into VianadoCastelo(Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@e_mail,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
            }

            static public int updatetvianadocastelo(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail,  string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                     new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("update [VianadoCastelo] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }
        }
        public class Vila_franca_de_xira
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from VilaFrancadeXira", null);
            }
            static public int insertVila_franca_de_xira(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("INSERT into VilaFrancadeXira(Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@e_mail,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
            }
            static public int updateVila_franca_de_xira(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail,  string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                     new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("update [VilaFrancadeXira] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }

        }
        public class Margem_Sul
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from MargemSul", null);
            }
            static public int insertMargemSul(string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail,string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("INSERT into MargemSul(Nome,Numero_de_contribuinte,data_de_nascimento,e_mail,Contacto,Nacionalidade,Habilitacoes_literarias) VALUES(@Nome,@Numero_de_contribuinte,@data_de_nascimento,@e_mail,@Contacto,@Nacionalidade,@Habilitacoes_literarias)", sqlParams);
            }
            static public int updatemargem_sul(int Id,string Nome, string Numero_de_contribuinte, string data_de_nascimento, string e_mail, string Contacto, string Nacionalidade, string Habilitacoes_literarias)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                     new SqlParameter("@Id", Id),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Numero_de_contribuinte", Numero_de_contribuinte),
                new SqlParameter("@e_mail", e_mail),
                new SqlParameter("@data_de_nascimento", data_de_nascimento),
                 new SqlParameter("@Contacto", Contacto),
                 new SqlParameter("@Nacionalidade", Nacionalidade),
                  new SqlParameter("@Habilitacoes_literarias", Habilitacoes_literarias)
             };
                return dal.executarNonQuery("update [MargemSul] set [data_de_nascimento]=@data_de_nascimento, [e_mail]=@e_mail, [Contacto]=@Contacto, [Numero_de_contribuinte]=@Numero_de_contribuinte, [Habilitacoes_literarias]=@Habilitacoes_literarias where [Id]=@Id", sqlParams);
            }

        }
        public class Margem_sult
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from MargemSul INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=MargemSul.Numero_de_contribuinte ", null);
            }
          
         

        }
        public class Alentejot
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Alentejo INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=Alentejo.Numero_de_contribuinte ", null);
            }
          
        }
        public class Algarvet
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Algarve INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=Algarve.Numero_de_contribuinte ", null);
            }

        }
        public class Almadat
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Almada INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=Almada.Numero_de_contribuinte ", null);
            }

        }
        public class Bragat
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Braga INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=Braga.Numero_de_contribuinte ", null);
            }

        }
        public class Cascaist
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Cascais INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=Cascais.Numero_de_contribuinte ", null);
            }

        }
        public class Castelo_Brancot
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Castelo_Branco INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=CasteloBranco.Numero_de_contribuinte ", null);
            }

        }
        public class Coimbrat
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Coimbra INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=Coimbra.Numero_de_contribuinte ", null);
            }

        }
        public class Covilhat
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Covilha INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=Covilha.Numero_de_contribuinte ", null);
            }

        }
        public class Evorat
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Évora INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=Évora.Numero_de_contribuinte ", null);
            }

        }
        public class Funchalt
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Funchal INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=Funchal.Numero_de_contribuinte ", null);
            }

        }
        public class Lisboat
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Lisboa INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=Lisboa.Numero_de_contribuinte ", null);
            }

        }
        public class Margem_Sult
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from MargemSul INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=MargemSul.Numero_de_contribuinte ", null);
            }

        }
        public class Odivelas_Lourest
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from OdivelasLoures INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=OdivelasLoures.Numero_de_contribuinte ", null);
            }

        }
        public class Oeirast
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Oeiras INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=Oeiras.Numero_de_contribuinte ", null);
            }

        }
        public class Portot
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Porto INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=Porto.Numero_de_contribuinte ", null);
            }

        }
        public class Santaremt
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Santarem INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=Santarem.Numero_de_contribuinte ", null);
            }

        }
        public class Setubalt
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Setubal INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=Setubal.Numero_de_contribuinte ", null);
            }

        }
        public class Sintrat
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Sintra INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=Sintra.Numero_de_contribuinte ", null);
            }

        }
        public class Viana_do_castelot
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from VianadoCastelo INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=VianadoCastelo.Numero_de_contribuinte ", null);
            }

        }
        public class Vila_Franca_de_Xirat
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from VilaFrancadeXira INNER JOIN Imagem ON Imagem.Numero_de_contribuinte=VilaFrancadeXira.Numero_de_contribuinte ", null);
            }

        }

    }
}


        ///   static public DataTable queryFuncionario_Like(String Nome)
        /// {
        ///      DAL dal = new DAL();
        ///       SqlParameter[] sqlParams = new SqlParameter[]{
        ///       new SqlParameter("@Nome", Nome + "%")
        ///      };
        ///      return dal.executarReader("select * from Funcionario where Nome like @Nome or telemovel like @Nome or e_mail like @Nome or palavra_passe like @Nome", sqlParams);
        ///   }
        ///     static public DataTable queryFuncionario(int id)
        ///    {
        ///        DAL dal = new DAL();
        ///          SqlParameter[] sqlParams = new SqlParameter[]{
        ///        new SqlParameter("@id", id)
        ///         };
        ///        return dal.executarReader("select * from Funcionario where ID=@id", sqlParams);
        ///    }
     ///   static public DataTable queryFuncionario_2(string Nome, string palavra_passe, string permissao)
     ///      {
            ///    DAL dal = new DAL();
           /*     SqlParameter[] sqlParams = new SqlParameter[]{
               
                 new SqlParameter("@Nome", Nome),
                 new SqlParameter("@palavra_passe", palavra_passe),
                 new SqlParameter("@permissao", permissao)
                };
                return dal.executarReader("select * from Funcionario where Nome=@Nome and palavra_passe=@palavra_passe and permissao=@permissao", sqlParams);
                   }
            static public DataTable queryFuncionario_3(int id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id)
                };
                return dal.executarReader("select * from Funcionario where ID=@id", sqlParams);
            }
            static public int updateFuncionario(int id, string Nome, string telemovel, string e_mail)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{                                                          
                new SqlParameter("@id", id),               
                new SqlParameter("@Nome", Nome),               
                new SqlParameter("@Telemovel", telemovel),
                new SqlParameter("@e_mail", e_mail)
                
            };
                return dal.executarNonQuery("update [Funcionario] set [Nome]=@Nome, [telemovel]=@telemovel, [e_mail]=@e_mail where [id]=@id", sqlParams);
            }
            static public int deleteFuncionario(string id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),
                           
            };
                return dal.executarNonQuery("Delete From Funcionario WHERE[id]=@id", sqlParams);

            }

            static public int alterarPerfil(string utilizador, String password, string imagem)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlparams = new SqlParameter[]{
                    new SqlParameter("@utilizador", utilizador),
                    new SqlParameter("@password", password),
                    new SqlParameter("@imagem", imagem)};

                return dal.executarNonQuery("update [utilizadores] set [password]=@password, [imagem]=@imagem where [utilizador]=@utilizador", sqlparams);
            }

            static public int alterarEstado(string utilizador, int estado)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlparams = new SqlParameter[]{
                    new SqlParameter("@utilizador", utilizador),
                    new SqlParameter("@estado", estado)};

                return dal.executarNonQuery("update utilizadores set estado=@estado where utilizador=@utilizador", sqlparams);
            }
        }

        public class imoveis
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from imoveis", null);
            }

            static public int insertimoveis(int referencia, string distrito, string conselho, string freguesia, string localidade, string preco, string estado, string tipologia, string natureza, string cert_energetico, string WC, string porta, string andar, string area, string tipo_de_imovel)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@referencia", referencia),
                new SqlParameter("@distrito", distrito),             
                new SqlParameter("@conselho", conselho),
                new SqlParameter("@freguesia", freguesia),
                new SqlParameter("@localidade", localidade),
                new SqlParameter("@preco", preco),
                new SqlParameter("@estado", estado),
                new SqlParameter("@tipologia", tipologia),
                new SqlParameter("@natureza", natureza),
                new SqlParameter("@cert_energetico", cert_energetico),
                new SqlParameter("@WC", WC),
                new SqlParameter("@porta", porta),
                new SqlParameter("@andar", andar),
                new SqlParameter("@area", area),
                new SqlParameter("@tipo_de_imovel",tipo_de_imovel ),
                
                               
           };

                return dal.executarNonQuery("INSERT into imoveis (referencia,distrito,conselho,freguesia,localidade,preco,estado,tipologia,natureza,cert_energetico,WC,porta,andar,area,tipo_de_imovel) VALUES (@referencia,@distrito,@conselho,@freguesia,@localidade,@preco,@estado,@tipologia,@natureza,@cert_energetico,@WC,@porta,@andar,@area,@tipo_de_imovel)", sqlParams);
                

            }
            static public DataTable queryimoveis_Like(String Nome)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome + "%")
                };
                return dal.executarReader("select * from clientes where Nome like @Nome", sqlParams);
            }
            static public DataTable queryimoveis(int referencia)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@referencia", referencia)
                };
                return dal.executarReader("select * from imoveis where referencia=@referencia", sqlParams);
            }
            static public DataTable queryimoveisloc(string localidade)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@localidade", localidade)
                };
                return dal.executarReader("select * from imoveis where localidade=@localidade", sqlParams);
            }
            static public DataTable queryimoveisnat(string natureza)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@natureza", natureza)
                };
                return dal.executarReader("select * from imoveis where natureza=@natureza", sqlParams);
            }


            static public DataTable queryimoveis_2(int referencia)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@referencia", referencia),
                
                };
                return dal.executarReader("select * from imoveis where referencia=@referencia", sqlParams);
            }
            static public DataTable queryimoveis_3(int referencia)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@referencia", referencia)
                };
                return dal.executarReader("select * from imoveis where referencia=@referencia", sqlParams);
            }
            static public int updateimovies(int referencia, string distrito, string conselho, string freguesia, string localidade, string preco, string estado, string tipologia, string natureza, string cert_energetico, string WC, string porta, string andar, string area )
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@referencia", referencia),
                new SqlParameter("@distrito", distrito),               
                new SqlParameter("@conselho", conselho),
                new SqlParameter("@freguesia", freguesia),
                new SqlParameter("@localidade", localidade),
                new SqlParameter("@preco", preco),
                new SqlParameter("@estado", estado),
                new SqlParameter("@tipologia", tipologia),
                new SqlParameter("@natureza", natureza),
                new SqlParameter("@cert_energetico", cert_energetico),
                new SqlParameter("@WC", WC),
                new SqlParameter("@porta", porta),
                new SqlParameter("@andar", andar),
                new SqlParameter("@area", area)
            };
                return dal.executarNonQuery("update [imoveis] set [distrito]=@distrito, [conselho]=@conselho, [freguesia]=@freguesia, [localidade]=@localidade, [preco]=@preco, [estado]=@estado, [tipologia]=@tipologia, [natureza]=@natureza, [cert_energetico]=@cert_energetico, [WC]=@WC, [porta]=@porta, [andar]=@andar, [area]=@area where [referencia]=@referencia", sqlParams);
            }
            static public int deleteimoveis(string referencia)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@referencia", referencia),
               
            };
                return dal.executarNonQuery("Delete From imoveis WHERE[referencia]=@referencia", sqlParams);
            }
            static public int alterarPerfil(string utilizador, String password, string imagem)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlparams = new SqlParameter[]{
                    new SqlParameter("@utilizador", utilizador),
                    new SqlParameter("@password", password),
                    new SqlParameter("@imagem", imagem)};

                return dal.executarNonQuery("update [utilizadores] set [password]=@password, [imagem]=@imagem where [utilizador]=@utilizador", sqlparams);
            }

            static public int alterarEstado(string utilizador, int estado)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlparams = new SqlParameter[]{
                    new SqlParameter("@utilizador", utilizador),
                    new SqlParameter("@estado", estado)};

                return dal.executarNonQuery("update utilizadores set estado=@estado where utilizador=@utilizador", sqlparams);
            }
        }

            public class Clientes
            {

                static public DataTable Load()
                {
                    DAL dal = new DAL();
                    return dal.executarReader("select * from clientes", null);
                }

                static public int insertCliente(string Nome, string Telemovel, string e_mail)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),             
                new SqlParameter("@Telemovel", Telemovel),
                new SqlParameter("@e_mail", e_mail),
           };

                    return dal.executarNonQuery("INSERT into clientes (Nome,Telemovel,e_mail) VALUES(@Nome,@Telemovel,@e_mail)", sqlParams);
                }
                static public DataTable queryCliente_Like(String Nome)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome + "%")
                };
                    return dal.executarReader("select * from clientes where Nome like @Nome or telemovel like @Nome or e_mail like @Nome", sqlParams);
                }
                static public DataTable queryCliente(int id)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id)
                };
                    return dal.executarReader("select * from clientes where ID=@id", sqlParams);
                }
                static public DataTable queryCliente_2(int id, string Nome)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),
                 new SqlParameter("@Nome", Nome)
                };
                    return dal.executarReader("select * from clientes where ID=@id and Nome=@Nome", sqlParams);
                }
                static public DataTable queryCliente_3(int id)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id)
                };
                    return dal.executarReader("select * from clientes where ID=@id", sqlParams);
                }
                static public int updateCliente(string id, string Nome, string Telemovel)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),
                new SqlParameter("@Nome", Nome),               
                new SqlParameter("@Telemovel", Telemovel)
            };
                    return dal.executarNonQuery("update [clientes] set [Nome]=@Nome, [Telemovel]=@Telemovel where [id]=@id", sqlParams);
                }
                static public int deleteCliente(string id)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),
                           
            };
                    return dal.executarNonQuery("Delete From clientes WHERE[id]=@id", sqlParams);

                }

                static public int alterarPerfil(string utilizador, String password, string imagem)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlparams = new SqlParameter[]{
                    new SqlParameter("@utilizador", utilizador),
                    new SqlParameter("@password", password),
                    new SqlParameter("@imagem", imagem)};

                    return dal.executarNonQuery("update [utilizadores] set [password]=@password, [imagem]=@imagem where [utilizador]=@utilizador", sqlparams);
                }

                static public int alterarEstado(string utilizador, int estado)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlparams = new SqlParameter[]{
                    new SqlParameter("@utilizador", utilizador),
                    new SqlParameter("@estado", estado)};

                    return dal.executarNonQuery("update utilizadores set estado=@estado where utilizador=@utilizador", sqlparams);
                }

            }

            public class Proprietario
            {

                static public DataTable Load()
                {
                    DAL dal = new DAL();
                    return dal.executarReader("select * from Proprietarios", null);
                }

                static public int insertproprietario(string Nome, string NIF, string Telemovel,string Distrito, string Natureza, string Tipologia, string Tipo_de_imovel )
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),    
                new SqlParameter("@NIF", NIF),
                new SqlParameter("@Telemovel", Telemovel),    
                new SqlParameter("@Distrito", Distrito),
                new SqlParameter("@Natureza", Natureza),
                new SqlParameter("@Tipologia",Tipologia ),
                new SqlParameter("@Tipo_de_imovel", Tipo_de_imovel)
           };

                    return dal.executarNonQuery("INSERT into Proprietarios (Nome,NIF,Telemovel,Distrito,Natureza,Tipologia,Tipo_de_imovel) VALUES(@Nome,@NIF,@Telemovel,@Distrito,@Natureza,@Tipologia,@Tipo_de_imovel)", sqlParams);
                }
                static public DataTable queryProprietario_Like(String Nome)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome + "%")
                };
                    return dal.executarReader("select * from Proprietarios where Nome like @Nome or telemovel like @Nome or e_mail like @Nome", sqlParams);
                }
                static public DataTable queryProprietario(string Nome)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome)
                };
                    return dal.executarReader("select * from Proprietarios where Nome=@Nome", sqlParams);
                }
                static public DataTable queryProprietario_2(int id, string Nome)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),
                 new SqlParameter("@Nome", Nome)
                };
                    return dal.executarReader("select * from Proprietarios where ID=@id and Nome=@Nome", sqlParams);
                }
                static public DataTable queryProprietario_3(int id)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id)
                };
                    return dal.executarReader("select * from Proprietarios where ID=@id", sqlParams);
                }
                static public int updateProprietario(int id, string Nome, string NIF ,string Telemovel,string Distrito, string Natureza, string Tipologia, string Tipo_de_imovel)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),
                new SqlParameter("@Nome", Nome),               
                new SqlParameter("@Telemovel", Telemovel),
                new SqlParameter("@Distrito", Distrito),
                new SqlParameter("@Natureza", Natureza),
                new SqlParameter("@Tipologia", Tipologia),
                new SqlParameter("@Tipo_de_imovel", Tipo_de_imovel),
            };
                    return dal.executarNonQuery("update [Proprietarios] set [Nome]=@Nome, [Telemovel]=@Telemovel, [Distrito]=@Distrito, [Natureza]=@Natureza, [Tipologia]=@Tipologia, [Tipo_de_imovel]=@tipo_de_imovel where [id]=@id", sqlParams);
                }
                static public int deleteProprietario(string id)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),
                           
            };
                    return dal.executarNonQuery("Delete From clientes WHERE[id]=@id", sqlParams);

                }

                static public int alterarPerfil(string utilizador, String password, string imagem)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlparams = new SqlParameter[]{
                    new SqlParameter("@utilizador", utilizador),
                    new SqlParameter("@password", password),
                    new SqlParameter("@imagem", imagem)};

                    return dal.executarNonQuery("update [utilizadores] set [password]=@password, [imagem]=@imagem where [utilizador]=@utilizador", sqlparams);
                }

                static public int alterarEstado(string utilizador, int estado)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlparams = new SqlParameter[]{
                    new SqlParameter("@utilizador", utilizador),
                    new SqlParameter("@estado", estado)};

                    return dal.executarNonQuery("update utilizadores set estado=@estado where utilizador=@utilizador", sqlparams);
                }*/

      //      }

           
    ///    }
   /// }

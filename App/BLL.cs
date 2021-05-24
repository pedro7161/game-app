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
                return dal.executarScalar("select Imagem from Monstros", sqlParams);

            }
          
            //Insere a imagem relativa ao numeroo de contribuinte
            static public int insertImagem(byte[] img,string nome)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@img", img),
                new SqlParameter("@nome", nome)

           };

                return dal.executarNonQuery("INSERT into Monstros (Imagem) VALUES(@img) where Name=@nome", sqlParams);
            }
        }

        public class Monstros
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Monstros", null);
            }
            static public int Inserir(string Name,string MHP,string MMP,string ATK,string DEF,string AGI,string LUK,string Category)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

             
                                new SqlParameter("@nome", Name),
                                                new SqlParameter("@mhp",MHP),
                                                               
                                                                                new SqlParameter("@mmp", MMP),
                                                                                 new SqlParameter("@atk", ATK),
                                                                                  new SqlParameter("@def", DEF),
                                                                                   new SqlParameter("@agi", AGI),
                                                                                    new SqlParameter("@luk", LUK),
                                                                                     new SqlParameter("@Categoria", Category),
                                                                                  


             };
                return dal.executarNonQuery("INSERT into Monstros (Name,MHP,MMP,ATK,DEF,AGI,LUK,Category) VALUES(@nome,@mhp,@MMP,@atk,@def,@agi,@luk,@Categoria)", sqlParams);
                //"INSERT into nomedatabela () VALUES(@variavel", sqlParams););
            }
            static public int fire(string Categoria)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@Categoria", Categoria),
               
             };
                return dal.executarNonQuery("select Id,Name,MHP,MMP,ATK,DEF,AGI,LUK,Category,Imagem from Monstros where Category=@Categoria ORDER BY ASC", sqlParams);
            }

            static public int earth(string Categoria)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@Categoria", Categoria),

             };
                return dal.executarNonQuery("SELECT * FROM Monstros WHERE Category LIKE %rth", sqlParams);//ORDER BY Name ASC
            }
            static public int dark(string Categoria)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@Categoria", Categoria),

             };
                return dal.executarNonQuery("select Id,Name,MHP,MMP,ATK,DEF,AGI,LUK,Category,Imagem from Monstros  where Category=@Categoria ORDER BY ASC", sqlParams);
            }
            static public int water(string Categoria)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@Categoria", Categoria),

             };
                return dal.executarNonQuery("select Id,Name,MHP,MMP,ATK,DEF,AGI,LUK,Category,Imagem from Monstros where Category=@Categoria ORDER BY ASC", sqlParams);
            }
            static public int earth2(string Categoria)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@Categoria", Categoria),

             };
                return dal.executarNonQuery("select Id,Name,MHP,MMP,ATK,DEF,AGI,LUK,Category,Imagem from Monstros  where Category=@Categoria ORDER BY DESC", sqlParams);
            }
            static public int dark2(string Categoria)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@Categoria", Categoria),

             };
                return dal.executarNonQuery("select Id,Name,MHP,MMP,ATK,DEF,AGI,LUK,Category,Imagem) from Monstros where Category=@Categoria ORDER BY DESC", sqlParams);
            }
            static public int water2(string Categoria)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@Categoria", Categoria),

             };
                return dal.executarNonQuery("select Id,Name,MHP,MMP,ATK,DEF,AGI,LUK,Category,Imagem from Monstros  where Category=@Categoria ORDER BY DESC", sqlParams);
            }
            static public int fire2(string Categoria)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@Categoria", Categoria),

             };
                return dal.executarNonQuery("select Id,Name,MHP,MMP,ATK,DEF,AGI,LUK,Category,Imagem from Monstros  where Category=@Categoria ORDER BY DESC", sqlParams);
            }
            static public int earth3(string Categoria)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@Categoria", Categoria),

             };
                return dal.executarNonQuery("select Id,Name,MHP,MMP,ATK,DEF,AGI,LUK,Category,Imagem from Monstros  where Category=@Categoria", sqlParams);
            }
            static public int dark3(string Categoria)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@Categoria", Categoria),

             };
                return dal.executarNonQuery("select Id,Name,MHP,MMP,ATK,DEF,AGI,LUK,Category,Imagem from Monstros where Category=@Categoria", sqlParams);
            }
            static public int water3(string Categoria)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@Categoria", Categoria),

             };
                return dal.executarNonQuery("select Id,Name,MHP,MMP,ATK,DEF,AGI,LUK,Category,Imagem from Monstros  where Category=@Categoria", sqlParams);
            }
            static public int fire3(string Categoria)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@Categoria", Categoria),

             };
                return dal.executarNonQuery("select Id,Name,MHP,MMP,ATK,DEF,AGI,LUK,Category,Imagem from Monstros where Category=@Categoria", sqlParams);
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

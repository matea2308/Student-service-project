using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis
{
    class Upiti
    {
        public static DataTable DohvatiPoslodavce()
        {
            DataSet dataSet = new DataSet();
            DataTable poslodavci = new DataTable();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM md.poslodavci", conn);
                dataAdapter.Fill(dataSet);
                poslodavci = dataSet.Tables[0];
            }
            return poslodavci;
        }

        public static DataTable DohvatiStudente()
        {
            DataSet dataSet = new DataSet();
            DataTable studenti = new DataTable();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT s.*, s.ime || ' ' ||s.prezime AS imeiprezime FROM md.studenti s", conn);
                dataAdapter.Fill(dataSet);
                studenti = dataSet.Tables[0];
            }
            return studenti;
        }

        public static DataTable DohvatiPoslove()
        {
            DataSet dataSet = new DataSet();
            DataTable poslovi = new DataTable();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM md.poslovi", conn);
                dataAdapter.Fill(dataSet);
                poslovi = dataSet.Tables[0];
            }
            return poslovi;
        }

        public static DataTable DohvatiUgovore()
        {
            DataSet dataSet = new DataSet();
            DataTable ugovori = new DataTable();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM md.ugovori", conn);
                dataAdapter.Fill(dataSet);
                ugovori = dataSet.Tables[0];
            }
            return ugovori;
        }

        public static BindingList<GrupaPoslova> PopisGrupaPoslova()
        {
            DataSet dataSet = new DataSet();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM md.grupe_poslova", conn);
                dataAdapter.Fill(dataSet);
            }

            var grupe = dataSet.Tables[0].AsEnumerable().Select(dataRow => new GrupaPoslova { ID_grupe = dataRow.Field<int>("id_grupe"), Naziv_grupe = dataRow.Field<string>("naziv_grupe") }).ToList();

            return new BindingList<GrupaPoslova>(grupe);
        }

        public static string DohvatiGrupuPosla(int ID_grupe)
        {
            DataSet dataSet = new DataSet();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM md.grupe_poslova WHERE ID_grupe = " + ID_grupe, conn);
                dataAdapter.Fill(dataSet);
            }

            var grupe = dataSet.Tables[0].AsEnumerable().Select(dataRow => new GrupaPoslova { ID_grupe = dataRow.Field<int>("id_grupe"), Naziv_grupe = dataRow.Field<string>("naziv_grupe") }).ToList();

            return grupe[0].Naziv_grupe;
        }

        public static BindingList<StrucnaSprema> PopisStrucnihSprema()
        {
            DataSet dataSet = new DataSet();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM md.strucne_spreme", conn);
                dataAdapter.Fill(dataSet);
            }

            var spreme = dataSet.Tables[0].AsEnumerable().Select(dataRow => new StrucnaSprema { ID_spreme = dataRow.Field<int>("id_spreme"), Kratica = dataRow.Field<string>("kratica"), Naziv = dataRow.Field<string>("naziv") }).ToList();

            return new BindingList<StrucnaSprema>(spreme);
        }

        public static string DohvatiStrucnuSpremu(int ID_spreme)
        {
            DataSet dataSet = new DataSet();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM md.strucne_spreme WHERE ID_spreme = "+ ID_spreme, conn);
                dataAdapter.Fill(dataSet);
            }

            var spreme = dataSet.Tables[0].AsEnumerable().Select(dataRow => new StrucnaSprema { ID_spreme = dataRow.Field<int>("id_spreme"), Kratica = dataRow.Field<string>("kratica"), Naziv = dataRow.Field<string>("naziv") }).ToList();

            return spreme[0].Kratica;
        }

        public static BindingList<Poslodavac> PopisPoslodavaca()
        {
            DataSet dataSet = new DataSet();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM md.poslodavci", conn);
                dataAdapter.Fill(dataSet);
            }

            var poslodavci = dataSet.Tables[0].AsEnumerable().Select(dataRow => new Poslodavac { ID_poslodavca = dataRow.Field<int>("id_poslodavca"), Sifra = dataRow.Field<string>("sifra"), Naziv = dataRow.Field<string>("naziv"), Sjediste = dataRow.Field<string>("sjediste"), OIB = dataRow.Field<string>("OIB") }).ToList();

            return new BindingList<Poslodavac>(poslodavci);
        }

        public static string DohvatiPoslodavca(int ID_poslodavca)
        {
            DataSet dataSet = new DataSet();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM md.poslodavci WHERE ID_poslodavca = " + ID_poslodavca, conn);
                dataAdapter.Fill(dataSet);
            }

            var poslodavci = dataSet.Tables[0].AsEnumerable().Select(dataRow => new Poslodavac { ID_poslodavca = dataRow.Field<int>("id_poslodavca"), Sifra = dataRow.Field<string>("sifra"), Naziv = dataRow.Field<string>("naziv"), Sjediste = dataRow.Field<string>("sjediste"), OIB = dataRow.Field<string>("OIB") }).ToList();

            return poslodavci[0].Naziv;
        }

        public static BindingList<Student> PopisStudenata()
        {
            DataSet dataSet = new DataSet();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT s.*, s.ime ||' ' ||s.prezime AS imeiprezime FROM md.studenti s", conn);
                dataAdapter.Fill(dataSet);
            }

            List<Student> studenti = dataSet.Tables[0].AsEnumerable().Select(dataRow => new Student { ID_studenta = dataRow.Field<int>("id_studenta"), ID_spreme = dataRow.Field<int>("id_spreme"), OIB = dataRow.Field<string>("OIB"), Ime = dataRow.Field<string>("ime"), Prezime = dataRow.Field<string>("prezime"), Adresa = dataRow.Field<string>("adresa"), DatumRodjenja = dataRow.Field<DateTime>("datum_rodjenja"), BrojIskaznice = dataRow.Field<string>("broj_studentske_iskaznice"), ImeIPrezime = dataRow.Field<string>("imeiprezime") }).ToList();

            foreach (Student student in studenti)
            {
                student.StrucnaSprema = DohvatiStrucnuSpremu(student.ID_spreme);
            }

            return new BindingList<Student>(studenti);
        }

        public static string DohvatiStudenta(int ID_studenta)
        {
            DataSet dataSet = new DataSet();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT s.*, s.ime ||' ' ||s.prezime AS imeiprezime FROM md.studenti s WHERE s.ID_studenta = " + ID_studenta, conn);
                dataAdapter.Fill(dataSet);
            }

            List<Student> studenti = dataSet.Tables[0].AsEnumerable().Select(dataRow => new Student { ID_studenta = dataRow.Field<int>("id_studenta"), ID_spreme = dataRow.Field<int>("id_spreme"), OIB = dataRow.Field<string>("OIB"), Ime = dataRow.Field<string>("ime"), Prezime = dataRow.Field<string>("prezime"), Adresa = dataRow.Field<string>("adresa"), DatumRodjenja = dataRow.Field<DateTime>("datum_rodjenja"), BrojIskaznice = dataRow.Field<string>("broj_studentske_iskaznice"), ImeIPrezime = dataRow.Field<string>("imeiprezime") }).ToList();

            foreach (Student student in studenti)
            {
                student.StrucnaSprema = DohvatiStrucnuSpremu(student.ID_spreme);
            }

            return studenti[0].ImeIPrezime;
        }

        public static BindingList<Posao> PopisPoslova()
        {
            DataSet dataSet = new DataSet();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM md.poslovi", conn);
                dataAdapter.Fill(dataSet);
            }

            var poslovi = dataSet.Tables[0].AsEnumerable().Select(dataRow => new Posao { ID_posla = dataRow.Field<int>("id_posla"), ID_grupe = dataRow.Field<int>("id_grupe"), VrstaPosla = dataRow.Field<string>("vrsta_posla"), Opis = dataRow.Field<string>("opis"), MjestoObavljanja = dataRow.Field<string>("mjesto_obavljanja"), Satnica = dataRow.Field<double>("satnica")}).ToList();
            
            foreach(Posao posao in poslovi)
            {
                posao.GrupaPosla = Upiti.DohvatiGrupuPosla(posao.ID_grupe);
            }

            return new BindingList<Posao>(poslovi);
        }

        public static string DohvatiPosao(int ID_posla)
        {
            DataSet dataSet = new DataSet();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM md.poslovi WHERE ID_posla = " + ID_posla, conn);
                dataAdapter.Fill(dataSet);
            }

            var poslovi = dataSet.Tables[0].AsEnumerable().Select(dataRow => new Posao { ID_posla = dataRow.Field<int>("id_posla"), ID_grupe = dataRow.Field<int>("id_grupe"), VrstaPosla = dataRow.Field<string>("vrsta_posla"), Opis = dataRow.Field<string>("opis"), MjestoObavljanja = dataRow.Field<string>("mjesto_obavljanja"), Satnica = dataRow.Field<double>("satnica") }).ToList();

            foreach (Posao posao in poslovi)
            {
                posao.GrupaPosla = Upiti.DohvatiGrupuPosla(posao.ID_grupe);
            }

            return poslovi[0].VrstaPosla;
        }

        public static double DohvatiSatnicu(int ID_posla)
        {
            DataSet dataSet = new DataSet();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM md.poslovi WHERE ID_posla = " + ID_posla, conn);
                dataAdapter.Fill(dataSet);
            }

            var poslovi = dataSet.Tables[0].AsEnumerable().Select(dataRow => new Posao { ID_posla = dataRow.Field<int>("id_posla"), ID_grupe = dataRow.Field<int>("id_grupe"), VrstaPosla = dataRow.Field<string>("vrsta_posla"), Opis = dataRow.Field<string>("opis"), MjestoObavljanja = dataRow.Field<string>("mjesto_obavljanja"), Satnica = dataRow.Field<double>("satnica") }).ToList();

            foreach (Posao posao in poslovi)
            {
                posao.GrupaPosla = Upiti.DohvatiGrupuPosla(posao.ID_grupe);
            }

            return poslovi[0].Satnica;
        }

        public static BindingList<Ugovor> PopisUgovora()
        {
            DataSet dataSet = new DataSet();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM md.ugovori", conn);
                dataAdapter.Fill(dataSet);
            }

            var ugovori = dataSet.Tables[0].AsEnumerable().Select(dataRow => new Ugovor { ID_ugovora = dataRow.Field<int>("id_ugovora"), ID_poslodavca = dataRow.Field<int>("id_poslodavca"), ID_posla = dataRow.Field<int>("id_posla"), ID_studenta = dataRow.Field<int>("id_studenta"), Trajanje = dataRow.Field<NpgsqlRange<DateTime>>("trajanje") }).ToList();

            foreach (Ugovor ugovor in ugovori)
            {
                ugovor.Student = Upiti.DohvatiStudenta(ugovor.ID_studenta);
                ugovor.Poslodavac = Upiti.DohvatiPoslodavca(ugovor.ID_poslodavca);
                ugovor.Posao = Upiti.DohvatiPosao(ugovor.ID_posla);
                ugovor.Satnica = Upiti.DohvatiSatnicu(ugovor.ID_posla);
            }

            return new BindingList<Ugovor>(ugovori);
        }

        public static BindingList<StavkaUgovora> PopisStavkiUgovora(int ID_ugovora)
        {
            DataSet dataSet = new DataSet();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM md.stavke_ugovora WHERE ID_ugovora = " + ID_ugovora, conn);
                dataAdapter.Fill(dataSet);
            }

            var stavkeUgovora = dataSet.Tables[0].AsEnumerable().Select(dataRow => new StavkaUgovora { ID_ugovora = dataRow.Field<int>("id_ugovora"), ID_stavke = dataRow.Field<int>("id_stavke"), VrstaRada = dataRow.Field<string>("vrsta_rada"), BrojSati = dataRow.Field<int>("broj_sati"), Cijena = dataRow.Field<double>("cijena"), Ukupno = dataRow.Field<double>("ukupno") }).ToList();

            return new BindingList<StavkaUgovora>(stavkeUgovora);
        }

        public static string DohvatiIznosZaIsplatiti(int ID_ugovora)
        {
            DataSet dataSet = new DataSet();

            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT SUM(ukupno) iznos_za_isplatiti FROM md.stavke_ugovora WHERE ID_ugovora = " + ID_ugovora, conn);
                dataAdapter.Fill(dataSet);
            }

            var iznos = dataSet.Tables[0].AsEnumerable().Select(dataRow => dataRow.Field<double?>("iznos_za_isplatiti")).ToList();

            return iznos[0].ToString();
        }

        public static bool UnesiStudenta(Student student)
        {
            string poruka = "";
            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                try
                {
                    // Insert some data
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO md.studenti (id_spreme, OIB, ime, prezime, adresa, datum_rodjenja, broj_studentske_iskaznice) VALUES (@1, @2, @3, @4, @5, @6, @7)";
                        cmd.Parameters.AddWithValue("1", student.ID_spreme);
                        cmd.Parameters.AddWithValue("2", student.OIB);
                        cmd.Parameters.AddWithValue("3", student.Ime);
                        cmd.Parameters.AddWithValue("4", student.Prezime);
                        cmd.Parameters.AddWithValue("5", student.Adresa);
                        cmd.Parameters.AddWithValue("6", student.DatumRodjenja);
                        cmd.Parameters.AddWithValue("7", student.BrojIskaznice);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    poruka = ex.Message;
                    return false;
                }
                finally
                {
                    if (!poruka.Equals(""))
                        MessageBox.Show(poruka, "Upozorenje", MessageBoxButtons.OK);
                }
            }
        }

        public static bool UrediStudenta(Student student)
        {
            string poruka = "";
            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                try
                {
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE md.studenti SET id_spreme = @1, OIB = @2, ime = @3, prezime = @4, adresa = @5, datum_rodjenja = @6, broj_studentske_iskaznice = @7 WHERE id_studenta = @8";
                        cmd.Parameters.AddWithValue("1", student.ID_spreme);
                        cmd.Parameters.AddWithValue("2", student.OIB);
                        cmd.Parameters.AddWithValue("3", student.Ime);
                        cmd.Parameters.AddWithValue("4", student.Prezime);
                        cmd.Parameters.AddWithValue("5", student.Adresa);
                        cmd.Parameters.AddWithValue("6", student.DatumRodjenja);
                        cmd.Parameters.AddWithValue("7", student.BrojIskaznice);
                        cmd.Parameters.AddWithValue("8", student.ID_studenta);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    poruka = ex.Message;
                    return false;
                }
                finally
                {
                    if (!poruka.Equals(""))
                        MessageBox.Show(poruka, "Upozorenje", MessageBoxButtons.OK);
                }
            }
        }

        public static bool ObrisiStudenta(int ID_studenta)
        {
            string poruka = "";
            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();
                try
                {
                    // Insert some data
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DELETE FROM md.studenti WHERE id_studenta = @1";
                        cmd.Parameters.AddWithValue("1", ID_studenta);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    poruka = ex.Message;
                    return false;
                }
                finally
                {
                    if (!poruka.Equals("")) MessageBox.Show(poruka, "Upozorenje", MessageBoxButtons.OK);
                }
            }
        }

        public static bool UnesiUgovor(Ugovor ugovor)
        {
            string poruka = "";
            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                try
                {
                    // Insert some data
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO md.ugovori (id_poslodavca, id_posla, id_studenta, trajanje) VALUES (@1, @2, @3, @4)";
                        cmd.Parameters.AddWithValue("1", ugovor.ID_poslodavca);
                        cmd.Parameters.AddWithValue("2", ugovor.ID_posla);
                        cmd.Parameters.AddWithValue("3", ugovor.ID_studenta);
                        cmd.Parameters.AddWithValue("4", ugovor.Trajanje);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    poruka = ex.Message;
                    return false;
                }
                finally
                {
                    if (!poruka.Equals(""))
                        MessageBox.Show(poruka, "Upozorenje", MessageBoxButtons.OK);
                }
                
            }
        }

        public static bool UrediUgovor(Ugovor ugovor)
        {
            string poruka = "";
            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                try
                {
                    // Insert some data
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE md.ugovori SET id_poslodavca = @1, id_posla = @2, id_studenta = @3, trajanje = @4 WHERE id_ugovora = @5";
                        cmd.Parameters.AddWithValue("1", ugovor.ID_poslodavca);
                        cmd.Parameters.AddWithValue("2", ugovor.ID_posla);
                        cmd.Parameters.AddWithValue("3", ugovor.ID_studenta);
                        cmd.Parameters.AddWithValue("4", ugovor.Trajanje);
                        cmd.Parameters.AddWithValue("5", ugovor.ID_ugovora);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    poruka = ex.Message;
                    return false;
                }
                finally
                {
                    if (!poruka.Equals(""))
                        MessageBox.Show(poruka, "Upozorenje", MessageBoxButtons.OK);
                }
                
            }
        }

        public static bool ObrisiUgovor(int ID_ugovora)
        {
            string poruka = "";
            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                try
                {
                    // Insert some data
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DELETE FROM md.ugovori WHERE id_ugovora = @1";
                        cmd.Parameters.AddWithValue("1", ID_ugovora);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    poruka = ex.Message;
                    return false;
                }
                finally
                {
                    if (!poruka.Equals(""))
                        MessageBox.Show(poruka, "Upozorenje", MessageBoxButtons.OK);
                }
                
            }
        }

        public static bool UnesiStavkuUgovora(StavkaUgovora stavka)
        {
            string poruka = "";
            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                try
                {
                    // Insert some data
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO md.stavke_ugovora (id_ugovora, vrsta_rada, broj_sati, cijena, ukupno) VALUES (@1, @2, @3, @4, @5)";
                        cmd.Parameters.AddWithValue("1", stavka.ID_ugovora);
                        cmd.Parameters.AddWithValue("2", stavka.VrstaRada);
                        cmd.Parameters.AddWithValue("3", stavka.BrojSati);
                        cmd.Parameters.AddWithValue("4", stavka.Cijena);
                        cmd.Parameters.AddWithValue("5", stavka.Ukupno);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    poruka = ex.Message;
                    return false;
                }
                finally
                {
                    if (!poruka.Equals(""))
                        MessageBox.Show(poruka, "Upozorenje", MessageBoxButtons.OK);
                }
                
            }
        }

        public static bool UrediStavkuUgovora(StavkaUgovora stavka)
        {
            string poruka = "";
            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                try
                {
                    // Insert some data
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE md.stavke_ugovora SET id_ugovora = @1, vrsta_rada = @2, broj_sati = @3, cijena = @4, ukupno = @5 WHERE id_stavke = @6";
                        cmd.Parameters.AddWithValue("1", stavka.ID_ugovora);
                        cmd.Parameters.AddWithValue("2", stavka.VrstaRada);
                        cmd.Parameters.AddWithValue("3", stavka.BrojSati);
                        cmd.Parameters.AddWithValue("4", stavka.Cijena);
                        cmd.Parameters.AddWithValue("5", stavka.Ukupno);
                        cmd.Parameters.AddWithValue("6", stavka.ID_stavke);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    poruka = ex.Message;
                    return false;
                }
                finally
                {
                    if (!poruka.Equals(""))
                        MessageBox.Show(poruka, "Upozorenje", MessageBoxButtons.OK);
                }
                
            }
        }

        public static bool ObrisiStavkuUgovora(int ID_stavke)
        {
            string poruka = "";
            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                try
                {
                    // Insert some data
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DELETE FROM md.stavke_ugovora WHERE id_stavke = @1";
                        cmd.Parameters.AddWithValue("1", ID_stavke);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    poruka = ex.Message;
                    return false;
                }
                finally
                {
                    if (!poruka.Equals(""))
                        MessageBox.Show(poruka, "Upozorenje", MessageBoxButtons.OK);
                }
                
            }
        }

        public static bool UnesiPosao(Posao posao)
        {
            string poruka = "";
            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                try
                {
                    // Insert some data
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO md.poslovi (id_grupe, vrsta_posla, opis, mjesto_obavljanja, satnica) VALUES (@1, @2, @3, @4, @5)";
                        cmd.Parameters.AddWithValue("1", posao.ID_grupe);
                        cmd.Parameters.AddWithValue("2", posao.VrstaPosla);
                        cmd.Parameters.AddWithValue("3", posao.Opis);
                        cmd.Parameters.AddWithValue("4", posao.MjestoObavljanja);
                        cmd.Parameters.AddWithValue("5", posao.Satnica);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    poruka = ex.Message;
                    return false;
                }
                finally
                {
                    if (!poruka.Equals(""))
                        MessageBox.Show(poruka, "Upozorenje", MessageBoxButtons.OK);
                }
            }
        }

        public static bool UrediPosao(Posao posao)
        {
            string poruka = "";
            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                try
                {
                    // Insert some data
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE md.poslovi SET id_grupe = @1, vrsta_posla = @2, opis = @3, mjesto_obavljanja = @4, satnica = @5 WHERE id_posla = @6";
                        cmd.Parameters.AddWithValue("1", posao.ID_grupe);
                        cmd.Parameters.AddWithValue("2", posao.VrstaPosla);
                        cmd.Parameters.AddWithValue("3", posao.Opis);
                        cmd.Parameters.AddWithValue("4", posao.MjestoObavljanja);
                        cmd.Parameters.AddWithValue("5", posao.Satnica);
                        cmd.Parameters.AddWithValue("6", posao.ID_posla);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    poruka = ex.Message;
                    return false;
                }
                finally
                {
                    if (!poruka.Equals(""))
                        MessageBox.Show(poruka, "Upozorenje", MessageBoxButtons.OK);
                }
            }
        }

        public static bool ObrisiPosao(int ID_posla)
        {
            string poruka = "";
            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();
                try
                {
                    // Insert some data
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DELETE FROM md.poslovi WHERE id_posla = @1";
                        cmd.Parameters.AddWithValue("1", ID_posla);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    poruka = ex.Message;
                    return false;
                }
                finally
                {
                    if (!poruka.Equals(""))
                        MessageBox.Show(poruka, "Upozorenje", MessageBoxButtons.OK);
                }
                
            }
        }

        public static bool UnesiPoslodavca(Poslodavac poslodavac)
        {
            string poruka = "";
            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                try
                {
                    // Insert some data
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO md.poslodavci (sifra, naziv, sjediste, oib) VALUES (@1, @2, @3, @4)";
                        cmd.Parameters.AddWithValue("1", poslodavac.Sifra);
                        cmd.Parameters.AddWithValue("2", poslodavac.Naziv);
                        cmd.Parameters.AddWithValue("3", poslodavac.Sjediste);
                        cmd.Parameters.AddWithValue("4", poslodavac.OIB);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    poruka = ex.Message;
                    return false;
                }
                finally
                {
                    if (!poruka.Equals(""))
                        MessageBox.Show(poruka, "Upozorenje", MessageBoxButtons.OK);
                }
            }
        }

        public static bool UrediPoslodavca(Poslodavac poslodavac)
        {
            string poruka = "";
            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                try
                {
                    // Insert some data
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE md.poslodavci SET sifra = @1, naziv = @2, sjediste = @3, oib = @4 WHERE id_poslodavca = @5";
                        cmd.Parameters.AddWithValue("1", poslodavac.Sifra);
                        cmd.Parameters.AddWithValue("2", poslodavac.Naziv);
                        cmd.Parameters.AddWithValue("3", poslodavac.Sjediste);
                        cmd.Parameters.AddWithValue("4", poslodavac.OIB);
                        cmd.Parameters.AddWithValue("5", poslodavac.ID_poslodavca);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    poruka = ex.Message;
                    return false;
                }
                finally
                {
                    if (!poruka.Equals(""))
                        MessageBox.Show(poruka, "Upozorenje", MessageBoxButtons.OK);
                }
                
            }
        }

        public static bool ObrisiPoslodavca(int ID_poslodavca)
        {
            string poruka = "";
            using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
            {
                conn.Open();

                try
                {
                    // Insert some data
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DELETE FROM md.poslodavci WHERE id_poslodavca = @1";
                        cmd.Parameters.AddWithValue("1", ID_poslodavca);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    poruka = ex.Message;
                    return false;
                }
                finally
                {
                    if (!poruka.Equals(""))
                        MessageBox.Show(poruka, "Upozorenje", MessageBoxButtons.OK);
                }
            }
        }

        public static BindingList<Izvjestaj> PrikaziIzvjestaj(string filtrirajPrema, string podUvjet)
        {

            DataSet dataSet = new DataSet();
            List<Izvjestaj> lista = null;

            string upit = "";
            
            switch (filtrirajPrema)
            {
                case "By Employer":
                    upit = "SELECT p.naziv naziv_poslodavca, COALESCE(SUM(su.ukupno), 0) ukupna_cijena FROM md.poslodavci p LEFT JOIN md.ugovori u ON p.ID_poslodavca = u.ID_poslodavca LEFT JOIN md.stavke_ugovora su ON u.ID_ugovora = su.ID_ugovora WHERE 1 = 1 " + podUvjet + " GROUP BY p.naziv";
                    using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
                    {
                        conn.Open();

                        NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, conn);
                        dataAdapter.Fill(dataSet);
                    }
                    lista = dataSet.Tables[0].AsEnumerable().Select(dataRow => new Izvjestaj { NazivPoslodavca = dataRow.Field<string>("naziv_poslodavca"), UkupnaCijena = dataRow.Field<double?>("ukupna_cijena") }).ToList();

                    break;
                case "By Student":
                    upit = "SELECT s.ime ||' ' || s.prezime naziv_studenta, COALESCE(SUM(su.broj_sati), 0) ukupno_sati, COALESCE(SUM(su.ukupno), 0) ukupna_cijena FROM md.studenti s LEFT JOIN md.ugovori u ON s.ID_studenta = u.ID_studenta LEFT JOIN md.stavke_ugovora su ON u.ID_ugovora = su.ID_ugovora WHERE 1 = 1 " + podUvjet + " GROUP BY s.ime || ' ' || s.prezime";
                    using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
                    {
                        conn.Open();

                        NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, conn);
                        dataAdapter.Fill(dataSet);
                    }
                    lista = dataSet.Tables[0].AsEnumerable().Select(dataRow => new Izvjestaj { NazivStudenta = dataRow.Field<string>("naziv_studenta"), UkupnoSati = dataRow.Field<long?>("ukupno_sati"), UkupnaCijena = dataRow.Field<double?>("ukupna_cijena") }).ToList();

                    break;
                case "By Month":
                    upit = "SELECT date_part('month', lower(trajanje)) mjesec, COALESCE(SUM(su.broj_sati), 0) ukupno_sati, COALESCE(SUM(su.ukupno), 0) ukupna_cijena FROM md.studenti s JOIN md.ugovori u ON s.ID_studenta = u.ID_studenta JOIN md.stavke_ugovora su ON u.ID_ugovora = su.ID_ugovora WHERE 1 = 1 GROUP BY date_part('month', lower(trajanje))";
                    using (var conn = new NpgsqlConnection(SqlConnection.ConnectionString))
                    {
                        conn.Open();

                        NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, conn);
                        dataAdapter.Fill(dataSet);
                    }
                    lista = dataSet.Tables[0].AsEnumerable().Select(dataRow => new Izvjestaj { Mjesec = dataRow.Field<double>("mjesec"), UkupnoSati = dataRow.Field<long?>("ukupno_sati"), UkupnaCijena = dataRow.Field<double?>("ukupna_cijena") }).ToList();

                    break;
                default:
                    break;
            }
            
            return new BindingList<Izvjestaj>(lista);
        }
    }
}

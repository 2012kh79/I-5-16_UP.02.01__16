using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_02._01
{
    class DBProcedures
    {
        private SqlCommand cmd = new SqlCommand("Empty",Registry_Class.sql);

        private void spConfiguration(string spName)
        {
            cmd.CommandText = spName;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        }



        public void spAccount_Insert(string loginAcc, string passwordAcc, Int32 role_id)
        {
            spConfiguration("account_insert");
            try
            {
                cmd.Parameters.AddWithValue("@login_acc", loginAcc);
                cmd.Parameters.AddWithValue("@password_acc", passwordAcc);
                cmd.Parameters.AddWithValue("@role_id", role_id);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spAccount_Update(Int32 id_account, string loginAcc, string passwordAcc, Int32 role_id)
        {
            spConfiguration("account_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_account", id_account);
                cmd.Parameters.AddWithValue("@loginAcc", loginAcc);
                cmd.Parameters.AddWithValue("@passwordAcc", passwordAcc);
                cmd.Parameters.AddWithValue("@role_id", role_id);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {   
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spAccount_Delete(Int32 id_account)
        {
            spConfiguration("account_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_account", id_account);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spFirma_Insert(string nazv_firmi)
        {
            spConfiguration("firma_insert");
            try
            {
                cmd.Parameters.AddWithValue("@nazv_firmi", nazv_firmi);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spFirma_Update(Int32 id_firma, string nazv_firm)
        {
            spConfiguration("firma_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_firma", id_firma);
                cmd.Parameters.AddWithValue("@loginAcc", nazv_firm);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spFirma_Delete(Int32 id_firma)
        {
            spConfiguration("firma_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_firma", id_firma);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

      
        public void spDocument_Insert(string vid_document)
        {
            spConfiguration("document_insert");
            try
            {
                cmd.Parameters.AddWithValue("@vid_document", vid_document);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                //Form1.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spDocument_Update(Int32 id_document, string vid_document)
        {
            spConfiguration("document_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_document", id_document);
                cmd.Parameters.AddWithValue("@vid_document", vid_document);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spDocument_Delete(Int32 id_document)
        {
            spConfiguration("document_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_account", id_document);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spDoljnost_Insert(string zanim_doljnost)
        {
            spConfiguration("doljnost_insert");
            try
            {
                cmd.Parameters.AddWithValue("@zanim_doljnost", zanim_doljnost);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                //Form1.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spDoljnost_Update(Int32 id_doljnost, string zanim_doljnost)
        {
            spConfiguration("doljnost_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_doljnost", id_doljnost);
                cmd.Parameters.AddWithValue("@zanim_doljnost", zanim_doljnost);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spDoljnost_Delete(Int32 id_doljnost)
        {
            spConfiguration("doljnost_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_dojnost", id_doljnost);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }


        public void spRole_Insert(string naim_role)
        {
            spConfiguration("role_insert");
            try
            {
                cmd.Parameters.AddWithValue("@role_insert", naim_role);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spRole_Update(Int32 id_role, string naim_role)
        {
            spConfiguration("role_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_role", id_role);
                cmd.Parameters.AddWithValue("@naim_role", naim_role);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spRole_Delete(Int32 id_role)
        {
            spConfiguration("role_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_role", id_role);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }          
        }


        public void spInstr_raboty_kassira_insert(string instr)
        {
            spConfiguration("instr_raboty_kassira_insert");
            try
            {
                cmd.Parameters.AddWithValue("@instr", instr);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spInstr_raboty_kassira_update(Int32 id_instr_raboty_kassira, string instr)
        {
            spConfiguration("instr_raboty_kassira_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_instr_raboty_kassira", id_instr_raboty_kassira);
                cmd.Parameters.AddWithValue("@instr", instr);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spInstr_rabory_kassira_delete(Int32 id_instr_raboty_kassira)
        {
            spConfiguration("instr_raboty_kassira_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_instr_raboty_kassira", id_instr_raboty_kassira);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spTovar_na_sklade_Insert(int srok_hran, int kol_tov_na_sklade, int nom_shkafa, int nom_polki)
        {
            spConfiguration("tovar_na_sklade_insert");
            try
            {
                cmd.Parameters.AddWithValue("@srok_hran", srok_hran);
                cmd.Parameters.AddWithValue("@kol_tov_na_sklade", kol_tov_na_sklade);
                cmd.Parameters.AddWithValue("@nom_shkafa", nom_shkafa);
                cmd.Parameters.AddWithValue("@nom_polki", nom_polki);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spTovar_na_sklade_Update(Int32 id_tovar_na_sklade, int srok_hran, int kol_tov_na_sklade, int nom_shkafa, int nom_polki)
        {
            spConfiguration("tovar_na_sklade_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_tovar_na_sklade", id_tovar_na_sklade);
                cmd.Parameters.AddWithValue("@srok_hran", srok_hran);
                cmd.Parameters.AddWithValue("@kol_tov_na_sklade", kol_tov_na_sklade);
                cmd.Parameters.AddWithValue("@nom_shkafa", nom_shkafa);
                cmd.Parameters.AddWithValue("@nom_polki", nom_polki);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spTovar_na_sklade_Delete(Int32 id_tovar_na_sklade)
        {
            spConfiguration("id_tovar_na_sklade");
            try
            {
                cmd.Parameters.AddWithValue("@id_tovar_na_sklade", id_tovar_na_sklade);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }
        public void spPost_tovar_Insert(string naim_post_tovara, int kol_post_tovara, float cena_post_tovara)
        {
            spConfiguration("post_tovar_insert");
            try
            {
                cmd.Parameters.AddWithValue("@naim_post_tovara", naim_post_tovara);
                cmd.Parameters.AddWithValue("@kol_post_tovara", kol_post_tovara);
                cmd.Parameters.AddWithValue("@cena_post_tovara", cena_post_tovara);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spPost_tovar_Update(Int32 id_post_tovar, string naim_post_tovara, int kol_post_tovara, float cena_post_tovara)
        {
            spConfiguration("post_tovar_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_post_tovar", id_post_tovar);
                cmd.Parameters.AddWithValue("@naim_post_tovara", naim_post_tovara);
                cmd.Parameters.AddWithValue("@kol_post_tovara", kol_post_tovara);
                cmd.Parameters.AddWithValue("@role_id", cena_post_tovara);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spPost_tovar_Delete(Int32 id_post_tovar)
        {
            spConfiguration("post_tovar_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_post_tovar", id_post_tovar);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }
        public void spTabel_rab_vremeni_Insert(int kol_otr_dney, int kol_vih_dney, int komandirovki, int otpuska)
        {
            spConfiguration("tabel_rab_vremeni_insert");
            try
            {
                cmd.Parameters.AddWithValue("@kol_otr_dney", kol_otr_dney);
                cmd.Parameters.AddWithValue("@kol_vih_dney", kol_vih_dney);
                cmd.Parameters.AddWithValue("@komandirovki", komandirovki);
                cmd.Parameters.AddWithValue("@otpuska", otpuska);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spTabel_rab_vremeni_Update(Int32 id_tabel_rab_vremeni, int kol_otr_dney, int kol_vih_dney, int komandirovki, int otpuska)
        {
            spConfiguration("tabel_rab_vremeni_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_tabel_rab_vremeni", id_tabel_rab_vremeni);
                cmd.Parameters.AddWithValue("@kol_otr_dney", kol_otr_dney);
                cmd.Parameters.AddWithValue("@kol_vih_dney", kol_vih_dney);
                cmd.Parameters.AddWithValue("@komandirovki", komandirovki);
                cmd.Parameters.AddWithValue("@otpuska", otpuska);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spTabel_rab_vremeni_Delete(Int32 id_tabel_rab_vremeni)
        {
            spConfiguration("tabel_rab_vremeni_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_tabel_rab_vremeni", id_tabel_rab_vremeni);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spDogovor_Insert(int nom_prikaza, string date_sost_prikaza, Int32 firma_id)
        {
            spConfiguration("dogovor_insert");
            try
            {
                cmd.Parameters.AddWithValue("@nom_prikaza", nom_prikaza);
                cmd.Parameters.AddWithValue("@date_sost_prikaza", date_sost_prikaza);
                cmd.Parameters.AddWithValue("@firma_id", firma_id);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spDogovor_Update(Int32 id_dogovor, int nom_prikaza, string date_sost_prikaza, Int32 firma_id)
        {
            spConfiguration("dogovor_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_dogovor", id_dogovor);
                cmd.Parameters.AddWithValue("@nom_prikaza", nom_prikaza);
                cmd.Parameters.AddWithValue("@date_sost_prikaza", date_sost_prikaza);
                cmd.Parameters.AddWithValue("@firma_id", firma_id);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spDogovor_Delete(Int32 id_dogovor)
        {
            spConfiguration("dogovor_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_dogovor", id_dogovor);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spSotrudnik_Insert(int tab_nom_sotr, string fam_sotr, string imya_sotr, string otch_sotr, Int32 dogovor_id, Int32 account_id)
        {
            spConfiguration("sotrudnik_insert");
            try
            {
                cmd.Parameters.AddWithValue("@tab_nom_sotr", tab_nom_sotr);
                cmd.Parameters.AddWithValue("@fam_sotr", fam_sotr);
                cmd.Parameters.AddWithValue("@imya_sotr", imya_sotr);
                cmd.Parameters.AddWithValue("@otch_sotr", otch_sotr);
                cmd.Parameters.AddWithValue("@dogovor_id", dogovor_id);
                cmd.Parameters.AddWithValue("@account_id", account_id);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spSotrudnik_Update(Int32 id_sotrudnik, int tab_nom_sotr, string fam_sotr, string imya_sotr, string otch_sotr, Int32 dogovor_id, Int32 account_id)
        {
            spConfiguration("dogovor_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_dogovor", id_sotrudnik);
                cmd.Parameters.AddWithValue("@tab_nom_sotr", tab_nom_sotr);
                cmd.Parameters.AddWithValue("@fam_sotr", fam_sotr);
                cmd.Parameters.AddWithValue("@imya_sotr", imya_sotr);
                cmd.Parameters.AddWithValue("@otch_sotr", otch_sotr);
                cmd.Parameters.AddWithValue("@dogovor_id", dogovor_id);
                cmd.Parameters.AddWithValue("@account_id", account_id);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spSotrudnik_Delete(Int32 id_sotrudnik)
        {
            spConfiguration("sotrudnik_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_sotrudnik", id_sotrudnik);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spFirma_postavki_Insert(string nazv_firmi_postavki, int index_post, string nas_punkt, string ulitsa, int dom)
        {
            spConfiguration("firma_postavki_insert");
            try
            {
                cmd.Parameters.AddWithValue("@nazv_firmi_postavki", nazv_firmi_postavki);
                cmd.Parameters.AddWithValue("@index_post", index_post);
                cmd.Parameters.AddWithValue("@nas_punkt", nas_punkt);
                cmd.Parameters.AddWithValue("@ulitsa", ulitsa);
                cmd.Parameters.AddWithValue("@dom", dom);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spFirma_postavki_Update(Int32 id_firma_postavki, string nazv_firmi_postavki, int index_post, string nas_punkt, string ulitsa, int dom)
        {
            spConfiguration("firma_postavki_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_firma_postavki", id_firma_postavki);
                cmd.Parameters.AddWithValue("@nazv_firmi_postavki", nazv_firmi_postavki);
                cmd.Parameters.AddWithValue("@index_post", index_post);
                cmd.Parameters.AddWithValue("@nas_punkt", nas_punkt);
                cmd.Parameters.AddWithValue("@ulitsa", ulitsa);
                cmd.Parameters.AddWithValue("@dom", dom);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spFirma_postavki_Delete(Int32 id_firma_postavki)
        {
            spConfiguration("firma_postavki_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_firma_postavki", id_firma_postavki);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spPostavshik_Insert(string fam_postavshika, string imya_postavshika, string otch_postavshika, Int32 firma_postavki_id)
        {
            spConfiguration("postavshik_insert");
            try
            {
                cmd.Parameters.AddWithValue("@fam_postavshika", fam_postavshika);
                cmd.Parameters.AddWithValue("@imya_postavshika", imya_postavshika);
                cmd.Parameters.AddWithValue("@otch_postavshika", otch_postavshika);
                cmd.Parameters.AddWithValue("@firma_postavki_id", firma_postavki_id);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spPostavshik_Update(Int32 id_postavshik, string fam_postavshika, string imya_postavshika, string otch_postavshika, Int32 firma_postavki_id)
        {
            spConfiguration("firma_postavki_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_postavshik", id_postavshik);
                cmd.Parameters.AddWithValue("@fam_postavshika", fam_postavshika);
                cmd.Parameters.AddWithValue("@imya_postavshika", imya_postavshika);
                cmd.Parameters.AddWithValue("@otch_postavshika", otch_postavshika);
                cmd.Parameters.AddWithValue("@firma_postavki_id", firma_postavki_id);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spPostavshik_Delete(Int32 id_postavshik)
        {
            spConfiguration("postavshik_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_postavshik", id_postavshik);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spPribil_i_rashodi_Insert(float pribil, float rashodi, string nach_otcheta, string kon_otcheta)
        {
            spConfiguration("pribil_i_rashodi_insert");
            try
            {
                cmd.Parameters.AddWithValue("@pribil", pribil);
                cmd.Parameters.AddWithValue("@rashodi", rashodi);
                cmd.Parameters.AddWithValue("@nach_otcheta", nach_otcheta);
                cmd.Parameters.AddWithValue("@kon_otcheta", kon_otcheta);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spPribil_i_rashodi_Update(Int32 id_pribil_i_rashodi, float pribil, float rashodi, string nach_otcheta, string kon_otcheta)
        {
            spConfiguration("pribil_i_rashodi_update");
            try
            {
                cmd.Parameters.AddWithValue("@pribil_i_rashodi", id_pribil_i_rashodi);
                cmd.Parameters.AddWithValue("@pribil", pribil);
                cmd.Parameters.AddWithValue("@rashodi", rashodi);
                cmd.Parameters.AddWithValue("@nach_otcheta", nach_otcheta);
                cmd.Parameters.AddWithValue("@kon_otcheta", kon_otcheta);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spPribil_i_rashodi_Delete(Int32 id_pribil_i_rashodi)
        {
            spConfiguration("pribil_i_rashodi_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_pribil_i_rashodi", id_pribil_i_rashodi);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spSoiskatel_Insert(string fam_soiskatel, string imya_soiskatel, string otch_soiskatel, Int32 tabel_rab_vremeni_id, Int32 dogovor_id)
        {
            spConfiguration("soiskatel_insert");
            try
            {
                cmd.Parameters.AddWithValue("@fam_soiskatel", fam_soiskatel);
                cmd.Parameters.AddWithValue("@imya_soiskatel", imya_soiskatel);
                cmd.Parameters.AddWithValue("@otch_soiskatel", otch_soiskatel);
                cmd.Parameters.AddWithValue("@tabel_rab_vremeni_id", tabel_rab_vremeni_id);
                cmd.Parameters.AddWithValue("@dogovor_id", dogovor_id);


                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spSoiskatel_Update(Int32 id_soiskatel, string fam_soiskatel, string imya_soiskatel, string otch_soiskatel, Int32 tabel_rab_vremeni_id, Int32 dogovor_id)
        {
            spConfiguration("soiskatel_update");
            try
            {
                cmd.Parameters.AddWithValue("@pribil_i_rashodi", id_soiskatel);
                cmd.Parameters.AddWithValue("@fam_soiskatel", fam_soiskatel);
                cmd.Parameters.AddWithValue("@imya_soiskatel", imya_soiskatel);
                cmd.Parameters.AddWithValue("@otch_soiskatel", otch_soiskatel);
                cmd.Parameters.AddWithValue("@tabel_rab_vremeni_id", tabel_rab_vremeni_id);
                cmd.Parameters.AddWithValue("@dogovor_id", dogovor_id);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spSoiskatel_Delete(Int32 id_soiskatel)
        {
            spConfiguration("soiskatel_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_soiskatel", id_soiskatel);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spPostavka_Insert(Int32 postavshik_id, Int32 tovar_na_sklade_id, Int32 post_tovar_id)
        {
            spConfiguration("postavka_insert");
            try
            {
                cmd.Parameters.AddWithValue("@postavshik_id", postavshik_id);
                cmd.Parameters.AddWithValue("@tovar_na_sklade_id", tovar_na_sklade_id);
                cmd.Parameters.AddWithValue("@post_tovar_id", post_tovar_id);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spPostavka_Update(Int32 id_postavka, Int32 postavshik_id, Int32 tovar_na_sklade_id, Int32 post_tovar_id)
        {
            spConfiguration("postavka_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_postavka", id_postavka);
                cmd.Parameters.AddWithValue("@postavshik_id", postavshik_id);
                cmd.Parameters.AddWithValue("@tovar_na_sklade_id", tovar_na_sklade_id);
                cmd.Parameters.AddWithValue("@post_tovar_id", post_tovar_id);


                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spPostavka_Delete(Int32 id_postavka)
        {
            spConfiguration("postavka_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_postavka", id_postavka);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spCheck_vid_med_Insert(int nom_check, string nazv_vid_med, Int32 doljnost_id, Int32 sotrudnik_id)
        {
            spConfiguration("check_vid_med_insert");
            try
            {
                cmd.Parameters.AddWithValue("@nom_check", nom_check);
                cmd.Parameters.AddWithValue("@nazv_vid_med", nazv_vid_med);
                cmd.Parameters.AddWithValue("@doljnost_id", doljnost_id);
                cmd.Parameters.AddWithValue("@sotrudnik_id", sotrudnik_id);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spCheck_vid_med_Update(Int32 id_check_vid_med, int nom_check, string nazv_vid_med, Int32 doljnost_id, Int32 sotrudnik_id)
        {
            spConfiguration("check_vid_med_update");
            try
            {
                cmd.Parameters.AddWithValue("@pribil_i_rashodi", id_check_vid_med);
                cmd.Parameters.AddWithValue("@nom_check", nom_check);
                cmd.Parameters.AddWithValue("@nazv_vid_med", nazv_vid_med);
                cmd.Parameters.AddWithValue("@doljnost_id", doljnost_id);
                cmd.Parameters.AddWithValue("@sotrudnik_id", sotrudnik_id);


                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spCheck_vid_med_Delete(Int32 id_check_vid_med)
        {
            spConfiguration("check_vid_med_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_check_vid_med", id_check_vid_med);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }


        public void spIdent_tov_party_Insert(string vid_doc, string tov_status, Int32 postavka_id)
        {
            spConfiguration("ident_tov_party_insert");
            try
            {
                cmd.Parameters.AddWithValue("@vid_doc", vid_doc);
                cmd.Parameters.AddWithValue("@tov_status", tov_status);
                cmd.Parameters.AddWithValue("@postavka_id", postavka_id);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spIdent_tov_party_Update(Int32 id_ident_tov_party, string vid_doc, string tov_status, Int32 postavka_id)
        {
            spConfiguration("ident_tov_party_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_ident_tov_party", id_ident_tov_party);
                cmd.Parameters.AddWithValue("@vid_doc", vid_doc);
                cmd.Parameters.AddWithValue("@tov_status", tov_status);
                cmd.Parameters.AddWithValue("@postavka_id", postavka_id);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spIdent_tov_party_Delete(Int32 id_ident_tov_party)
        {
            spConfiguration("ident_tov_party_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_ident_tov_party", id_ident_tov_party);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }


        public void spMedicamenti_Insert(int kol_vid_med, Int32 check_vid_med_id)
        {
            spConfiguration("medicamenti_insert");
            try
            {
                cmd.Parameters.AddWithValue("@kol_vid_med", kol_vid_med);
                cmd.Parameters.AddWithValue("@check_vid_med_id", check_vid_med_id);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spMedicamenti_Update(Int32 id_medicamenti, int kol_vid_med, Int32 check_vid_med_id)
        {
            spConfiguration("medicamenti_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_medicamenti", id_medicamenti);
                cmd.Parameters.AddWithValue("@kol_vid_med", kol_vid_med);
                cmd.Parameters.AddWithValue("@check_vid_med_id", check_vid_med_id);


                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spMedicamenti_Delete(Int32 id_medicamenti)
        {
            spConfiguration("medicamenti_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_medicamenti", id_medicamenti);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spKadr_perestanovki_Insert(string date_podpisi_document, Int32 sotrudnik_id, Int32 doljnost_id, Int32 document_id, Int32 soiskatel_id)
        {
            spConfiguration("kadr_perestanovki_insert");
            try
            {
                cmd.Parameters.AddWithValue("@date_podpisi_document", date_podpisi_document);
                cmd.Parameters.AddWithValue("@sotrudnik_id", sotrudnik_id);
                cmd.Parameters.AddWithValue("@document_id", document_id);
                cmd.Parameters.AddWithValue("@soiskatel_id", soiskatel_id);

                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spKadr_perestanovki_Update (Int32 id_kadr_perestanovki,  string date_podpisi_document, Int32 sotrudnik_id, Int32 doljnost_id, Int32 document_id, Int32 soiskatel_id)
        {
            spConfiguration("kadr_perestanovki_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_kadr_perestanovki", id_kadr_perestanovki);
                cmd.Parameters.AddWithValue("@date_podpisi_documen", date_podpisi_document);
                cmd.Parameters.AddWithValue("@sotrudnik_id", sotrudnik_id);
                cmd.Parameters.AddWithValue("@document_id", document_id);
                cmd.Parameters.AddWithValue("@soiskatel_id", soiskatel_id);


                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spKadr_perestanovki_Delete(Int32 id_kadr_perestanovki)
        {
            spConfiguration("kadr_perestanovki_delete");
            try
            {
                cmd.Parameters.AddWithValue("id_kadr_perestanovki", id_kadr_perestanovki);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spTabel_zarplata_Insert(float zarplata, Int32 kadr_perestanovki_id)
        {
            spConfiguration("tabel_zarplata_insert");
            try
            {
                cmd.Parameters.AddWithValue("@zarplata", zarplata);
                cmd.Parameters.AddWithValue("@kadr_perestanovki_id", kadr_perestanovki_id);


                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spTabel_zarplata_Update(Int32 id_tabel_zarplata, float zarplata, Int32 kadr_perestanovki_id)
        {
            spConfiguration("tabel_zarplata_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_tabel_zarplata", id_tabel_zarplata);
                cmd.Parameters.AddWithValue("@zarplata", zarplata);
                cmd.Parameters.AddWithValue("@kadr_perestanovki_id", kadr_perestanovki_id);


                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spTabel_zarplata_Delete(Int32 id_tabel_zarplata)
        {
            spConfiguration("kadr_perestanovki_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_tabel_zarplata", id_tabel_zarplata);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spKadr_uchet_Insert(Int32 sotrudnik_id, Int32 tabel_zarplata_id, Int32 pribil_i_rashodi_id)
        {
            spConfiguration("kadr_uchet_insert");
            try
            {

                cmd.Parameters.AddWithValue("@sotrudnik_id", sotrudnik_id);
                cmd.Parameters.AddWithValue("@tabel_zarplata_id", tabel_zarplata_id);
                cmd.Parameters.AddWithValue("@pribil_i_rashodi_id", pribil_i_rashodi_id);


                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spKadr_uchet_Update(Int32 id_kadr_uchet, Int32 sotrudnik_id, Int32 tabel_zarplata_id, Int32 pribil_i_rashodi_id)
        {
            spConfiguration("kadr_uchet_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_kadr_uchet", id_kadr_uchet);
                cmd.Parameters.AddWithValue("@sotrudnik_id", sotrudnik_id);
                cmd.Parameters.AddWithValue("@tabel_zarplata_id", tabel_zarplata_id);
                cmd.Parameters.AddWithValue("@pribil_i_rashodi_id", pribil_i_rashodi_id);


                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spKadr_uchet_Delete(Int32 id_kadr_uchet)
        {
            spConfiguration("kadr_uchet_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_kadr_uchet", id_kadr_uchet);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }


        public void spProdaja_tovara_Insert(Int32 medicamenti_id, Int32 instr_raboty_kassira_id)
        {
            spConfiguration("prodaja_tovara_insert");
            try
            {

                cmd.Parameters.AddWithValue("@medicamenti_id", medicamenti_id);
                cmd.Parameters.AddWithValue("@instr_raboty_kassira_id", instr_raboty_kassira_id);


                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spProdaja_tovara_Update(Int32 id_prodaja_tovara, Int32 medicamenti_id, Int32 instr_raboty_kassira_id)
        {
            spConfiguration("prodaja_tovara_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_prodaja_tovara", id_prodaja_tovara);
                cmd.Parameters.AddWithValue("@medicamenti_id", medicamenti_id);
                cmd.Parameters.AddWithValue("@instr_raboty_kassira_id", instr_raboty_kassira_id);


                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spProdaja_tovara_Delete(Int32 id_prodaja_tovara)
        {
            spConfiguration("prodaja_tovara_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_prodaja_tovara", id_prodaja_tovara);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }


        public void spVih_doc_Insert(Int32 prodaja_tovara_id, Int32 kadr_uchet_id, Int32 ident_tov_party_id)
        {
            spConfiguration("vih_doc_insert");
            try
            {

                cmd.Parameters.AddWithValue("@prodaja_tovara_id", prodaja_tovara_id);
                cmd.Parameters.AddWithValue("@kadr_uchet_id", kadr_uchet_id);
                cmd.Parameters.AddWithValue("@ident_tov_party_id", ident_tov_party_id);


                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spVih_doc_Update(Int32 id_vih_doc, Int32 prodaja_tovara_id, Int32 kadr_uchet_id, Int32 ident_tov_party_id)
        {
            spConfiguration("vih_doc_update");
            try
            {
                cmd.Parameters.AddWithValue("@id_vih_doc", id_vih_doc);
                cmd.Parameters.AddWithValue("@prodaja_tovara_id", prodaja_tovara_id);
                cmd.Parameters.AddWithValue("@kadr_uchet_id", kadr_uchet_id);
                cmd.Parameters.AddWithValue("@ident_tov_party_id", ident_tov_party_id);


                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spVih_doc_Delete(Int32 id_vih_doc)
        {
            spConfiguration("vih_doc_delete");
            try
            {
                cmd.Parameters.AddWithValue("@id_vih_doc", id_vih_doc);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }
    }
}

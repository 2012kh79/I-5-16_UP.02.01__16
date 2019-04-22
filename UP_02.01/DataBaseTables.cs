using System;
using System.Data.SqlClient;
using System.Data;

namespace UP_02._01
{
    class DataBaseTables
    {
        public SqlCommand command = new SqlCommand("", Registry_Class.sql);
        public DataTable dtAccount = new DataTable("account");
        public DataTable dtCheck_vid_med = new DataTable("check_vid_med");
        public DataTable dtDocument = new DataTable("document");
        public DataTable dtDogovor = new DataTable("dogovor");
        public DataTable dtDoljnost = new DataTable("doljnost");
        public DataTable dtFirma = new DataTable("firma");
        public DataTable dtFirma_postavki = new DataTable("firma_postavki");
        public DataTable dtIdent_tov_party = new DataTable("ident_tov_party");
        public DataTable dtInstr_raboty_kassira = new DataTable("instr_raboty_kassira");
        public DataTable dtKadr_perestanovki = new DataTable("kadr_perestanovki");
        public DataTable dtKadr_uchet = new DataTable("kadr_uchet");
        public DataTable dtMedicamenti = new DataTable("medicamenti");
        public DataTable dtPost_tovar = new DataTable("post_tovar");
        public DataTable dtPostavka = new DataTable("postavka");
        public DataTable dtPostavshik = new DataTable("postavshik");
        public DataTable dtPribil_i_rashodi = new DataTable("pribil_i_rashodi");
        public DataTable dtProdaja_tovara = new DataTable("prodaja_tovara");
        public DataTable dtRole = new DataTable("role");
        public DataTable dtSoiskatel = new DataTable("soiskatel");
        public DataTable dtSotrudnik = new DataTable("sotrudnik");
        public DataTable dtTabel_rab_vremeni = new DataTable("tabel_rab_vremeni");
        public DataTable dtTabel_zarplata = new DataTable("tabel_zarplata");
        public DataTable dtTovar_na_sklade = new DataTable("tovar_na_sklade");
        public DataTable dtVih_doc = new DataTable("vih_doc");
        public DataTable dtTr_pribil_i_rashodi = new DataTable("tr_pribil_i_rashodi");
        public SqlDependency dependency = new SqlDependency();
        public string qrAccount = "select [id_account],[login_acc],[password_acc],[role_id] from [dbo].[account]",
            qrCheck_vid_med = "select [id_check_vid_med],[nom_check],[nazv_vid_med],[doljnost_id],[sotrudnik_id],[id_doljnost],[zanim_doljnost],[id_sotrudnik],[tab_nom_sotr],[fam_sotr]+' '+[imya_sotr]+' '+[otch_sotr] as \"Full_Name_Sotrudnik\" from [dbo].[check_vid_med] inner join [dbo].[sotrudnik] on [dbo].[sotrudnik].[id_sotrudnik] = [dbo].[check_vid_med].[sotrudnik_id] inner join [dbo].[doljnost] on [dbo].[doljnost].[id_doljnost]=[dbo].[check_vid_med].[doljnost_id]",
            qrDocument = "select [id_document],[vid_document] from [dbo].[document]",
            qrDogovor = "select [id_dogovor],[nom_prikaza],[date_sost_prikaza],[firma_id],[id_firma],[nazv_firmi] from [dbo].[dogovor] inner join [dbo].[firma] on [dbo].[firma].[id_firma] = [dbo].[dogovor].[firma_id]",
            qrDoljnost = "select [id_doljnost],[zanim_doljnost] from [dbo].[doljnost]",
            qrFirma = "select [id_firma],[nazv_firmi] from [dbo].[firma]",
            qrFirma_postavki = "select [id_firma_postavki],[nazv_firmi_postavki],[index_post],[nas_punkt],[ulitsa],[dom],[nas_punkt]+','+[ulitsa]+','+Convert(varchar(3),[dom]) as \"Adres_postavki\" from [dbo].[firma_postavki]",
            qrIdent_tov_party = "select [id_ident_tov_party],[vid_doc],[tov_status],[postavka_id],[id_postavka] from [dbo].[ident_tov_party] inner join [dbo].[postavka] on [dbo].[postavka].[id_postavka] = [dbo].[ident_tov_party].[postavka_id]",
            qrInstr_rabory_kassira = "select [id_instr_raboty_kassira],[instr] from [dbo].[instr_raboty_kassira]",
            qrKadr_perestanovki = "select [id_kadr_perestanovki],[date_podpisi_document],[sotrudnik_id],[doljnost_id],[document_id],[soiskatel_id],[id_sotrudnik],[tab_nom_sotr],[fam_sotr]+' '+[imya_sotr]+' '+[otch_sotr] as \"Full_Name_Sotrudnik\",[id_doljnost],[zanim_doljnost],[id_document],[vid_document],[id_soiskatel],[fam_soiskatel]+' '+[imya_soiskatel]+' '+[otch_soiskatel] as \"Full_Name_Soiskatel\" from [dbo].[kadr_perestanovki] inner join [dbo].[sotrudnik] on [dbo].[sotrudnik].[id_sotrudnik] = [dbo].[kadr_perestanovki].[sotrudnik_id] inner join [dbo].[doljnost] on [dbo].[doljnost].[id_doljnost] = [dbo].[kadr_perestanovki].[doljnost_id] inner join [dbo].[document] on [dbo].[document].[id_document] = [dbo].[kadr_perestanovki].[document_id] inner join [dbo].[soiskatel] on [dbo].[soiskatel].[id_soiskatel] = [dbo].[kadr_perestanovki].[soiskatel_id]",
            qrKadr_uchet = "select [id_kadr_uchet],[sotrudnik_id],[tabel_zarplata_id],[pribil_i_rashodi_id],[id_sotrudnik],[tab_nom_sotr],[fam_sotr]+' '+[imya_sotr]+' '+[otch_sotr] as \"Full_Name_Sotrudnik\",[id_tabel_zarplata],[zarplata],[id_pribil_i_rashodi],[pribil],[rashodi],[nach_otcheta]+'-'+[kon_otcheta] as \"Nach_Konets_otcheta\" from [dbo].[kadr_uchet] inner join [dbo].[sotrudnik] on [dbo].[sotrudnik].[id_sotrudnik] = [dbo].[kadr_uchet].[sotrudnik_id] inner join [dbo].[tabel_zarplata] on [dbo].[tabel_zarplata].[id_tabel_zarplata] = [dbo].[kadr_uchet].[tabel_zarplata_id] inner join [dbo].[pribil_i_rashodi] on [dbo].[pribil_i_rashodi].[id_pribil_i_rashodi] = [dbo].[kadr_uchet].[pribil_i_rashodi_id]",
            qrMedicamenti = "select [id_medicamenti],[kol_vid_med],[check_vid_med_id],[id_check_vid_med],[nom_check],[nazv_vid_med] from [dbo].[medicamenti] inner join [dbo].[check_vid_med] on [dbo].[check_vid_med].[id_check_vid_med] = [dbo].[medicamenti].[check_vid_med_id]",
            qrPost_tovar = "select [id_post_tovar],[naim_post_tovara],[kol_post_tovara],[cena_post_tovara] from [dbo].[post_tovar]",
            qrPostavka = "select [id_postavka],[postavshik_id],[tovar_na_sklade_id],[post_tovar_id],[id_postavshik],[fam_postavshika]+' '+[imya_postavshika]+' '+[otch_postavshika] as \"Full_Name_Postavshik\",[id_tovar_na_sklade],[srok_hran],[kol_tov_na_sklade],[nom_shkafa],[nom_polki],[id_post_tovar],[naim_post_tovara],[kol_post_tovara],[cena_post_tovara] from [dbo].[Postavka] inner join [dbo].[postavshik] on [dbo].[postavshik].[id_postavshik] = [dbo].[postavka].[postavshik_id] inner join [dbo].[tovar_na_sklade] on [dbo].[tovar_na_sklade].[id_tovar_na_sklade] = [dbo].[postavka].[tovar_na_sklade_id] inner join [dbo].[post_tovar] on [dbo].[post_tovar].[id_post_tovar] = [dbo].[postavka].[post_tovar_id]",
            qrPostavshik = "select [id_postavshik],[fam_postavshika],[imya_postavshika],[otch_postavshika],[firma_postavki_id],[id_firma_postavki],[nazv_firmi_postavki],[index_post],[nas_punkt]+','+[ulitsa]+','+Convert(varchar(3),[dom]) as \"Adres_postavki\" from [dbo].[postavshik] inner join [dbo].[firma_postavki] on [dbo].[firma_postavki].[id_firma_postavki] = [dbo].[postavshik].[firma_postavki_id]",
            qrPribil_i_rashodi = "select [id_pribil_i_rashodi],[pribil],[rashodi],[nach_otcheta],[kon_otcheta] from [dbo].[pribil_i_rashodi]",
            qrProdaja_tovara = "select [id_prodaja_tovara],[medicamenti_id],[instr_raboty_kassira_id],[id_medicamenti],[kol_vid_med],[id_instr_raboty_kassira],[instr] from [dbo].[prodaja_tovara] inner join [dbo].[medicamenti] on [dbo].[medicamenti].[id_medicamenti] = [dbo].[prodaja_tovara].[medicamenti_id] inner join [dbo].[instr_raboty_kassira] on [dbo].[instr_raboty_kassira].[id_instr_raboty_kassira] = [dbo].[prodaja_tovara].[instr_raboty_kassira_id]",
            qrRole = "select [id_role],[naim_role] from [dbo].[role]",
            qrSoiskatel = "select [id_soiskatel],[fam_soiskatel],[imya_soiskatel],[otch_soiskatel],[tabel_rab_vremeni_id],[dogovor_id],[fam_soiskatel]+' '+[imya_soiskatel]+' '+[otch_soiskatel] as \"Full_Name_Soiskatel\",[id_tabel_rab_vremeni],[kol_otr_dney],[kol_vih_dney],[komandirovki],[otpuska],[id_dogovor],[nom_prikaza],[date_sost_prikaza] from [dbo].[soiskatel] inner join [dbo].[tabel_rab_vremeni] on [dbo].[tabel_rab_vremeni].[id_tabel_rab_vremeni] = [dbo].[soiskatel].[tabel_rab_vremeni_id] inner join [dbo].[dogovor] on [dbo].[dogovor].[id_dogovor] = [dbo].[soiskatel].[dogovor_id]",
            qrSotrudnik = "select [id_sotrudnik],[fam_sotr],[imya_sotr],[otch_sotr],[tabel_rab_vremeni_id],[dogovor_id],[account_id],[fam_sotr]+' '+[imya_sotr]+' '+[otch_sotr] as \"Full_Name_Sotrudnik\",[id_tabel_rab_vremeni],[kol_otr_dney],[kol_vih_dney],[komandirovki],[otpuska],[id_dogovor],[nom_prikaza],[date_sost_prikaza],[id_account],[login_acc],[password_acc] from [dbo].[sotrudnik] inner join [dbo].[tabel_rab_vremeni] on [dbo].[tabel_rab_vremeni].[id_tabel_rab_vremeni] = [dbo].[sotrudnik].[tabel_rab_vremeni_id] inner join [dbo].[dogovor] on [dbo].[dogovor].[id_dogovor] = [dbo].[sotrudnik].[dogovor_id] inner join [dbo].[account] on [dbo].[account].[id_account] = [dbo].[sotrudnik].[account_id]",
            qrTabel_rab_vremeni = "select [id_tabel_tab_vremeni],[kol_otr_dney],[kol_vih_dney],[komandirovki],[otpuska] from [dbo].[tabel_rab_vremeni]",
            qrTabel_zarplata = "select [id_tabel_zarplata],[zarplata],[kadr_perestanovki_id],[id_kadr_perestanovki],[date_podpisi_document] from [dbo].[tabel_zarplata] inner join [dbo].[kadr_perestanovki] on [dbo].[kadr_perestanovki].[id_kadr_perestanovki] = [tabel_zarplata].[kadr_perestanovki_id]",
            qrTovar_na_sklade = "select [id_tovar_na_sklade],[srok_hran],[kol_tov_na_sklade],[nom_shkafa],[nom_polki] from [dbo].[tovar_na_skalde]",
            qrVih_doc = "select [id_vih_doc],[prodaja_tovara_id],[kadr_uchet_id],[ident_tov_party_id],[id_prodaja_tovara],[id_kadr_uchet],[id_ident_tov_party],[vid_doc],[tov_status] from [dbo].[vih_doc] inner join [dbo].[prodaja_tovara] on [dbo].[prodaja_tovara].[id_prodaja_tovara] = [dbo].[vih_doc].[prodaja_tovara_id] inner join [dbo].[kadr_uchet] on [dbo].[kadr_uchet].[id_kadr_uchet] = [dbo].[vih_doc].[kadr_uchet_id] inner join [dbo].[ident_tov_party] on [dbo].[ident_tov_party].[id_ident_tov_party] = [dbo].[vih_doc].[ident_tov_party_id]",
            qrTr_pribil_i_rashodi = "select [id_pribil_i_rashodi_old],[id_pribil_i_rashodi_new],[pribil_old],[pribil_new],[rashodi_old],[rashodi_new],[nach_otcheta_new],[nach_otcheta_old],[kon_otcheta_old],[kon_otcheta_new],[data] from [u0695785_TatarBase].[tr_pribil_i_rashodi]";

        public void dtFill(DataTable table, string query)
        {
            try
            {
                command.Notification = null;
                command.CommandText = query;
                //dependency.AddCommandDependency(command);
                SqlDependency.Start(Registry_Class.sql.ConnectionString);
                Registry_Class.sql.Open();
                table.Load(command.ExecuteReader());
            }
            catch (Exception ex)
            {
                Registry_Class.error_message += "\n"
                    + DateTime.Now.ToLongDateString() + ex.Message;
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void dtAccountFill()
        {
            dtFill(dtAccount, qrAccount);
        }

        public void dtCheck_vid_medFill()
        {
            dtFill(dtCheck_vid_med, qrCheck_vid_med);
        }

        public void dtDocumentFill()
        {
            dtFill(dtDocument, qrDocument);
        }

        public void dtDogovorFill()
        {
            dtFill(dtDogovor, qrDogovor);
        }

        public void dtDoljnostFill()
        {
            dtFill(dtDoljnost, qrDoljnost);
        }

        public void dtFirmaFill()
        {
            dtFill(dtFirma, qrFirma);
        }

        public void dtFirma_postavkiFill()
        {
            dtFill(dtFirma_postavki, qrFirma_postavki);
        }

        public void dtIdent_tov_partyFill()
        {
            dtFill(dtIdent_tov_party, qrIdent_tov_party);
        }

        public void dtInstr_raboty_kassiraFill()
        {
            dtFill(dtInstr_raboty_kassira, qrInstr_rabory_kassira);
        }

        public void dtKadr_perestanovkiFill()
        {
            dtFill(dtKadr_perestanovki, qrKadr_perestanovki);
        }

        public void dtKadr_uchetFill()
        {
            dtFill(dtKadr_uchet, qrKadr_uchet);
        }

        public void dtMedicamentiFill()
        {
            dtFill(dtMedicamenti, qrMedicamenti);
        }

        public void dtPost_tovarFill()
        {
            dtFill(dtPost_tovar, qrPost_tovar);
        }

        public void dtPostavkaFill()
        {
            dtFill(dtPostavka, qrPostavka);
        }

        public void dtPostavshikFill()
        {
            dtFill(dtPostavshik, qrPostavshik);
        }

        public void dtPribil_i_rashodiFill()
        {
            dtFill(dtPribil_i_rashodi, qrPribil_i_rashodi);
        }

        public void dtProdaja_tovaraFill()
        {
            dtFill(dtProdaja_tovara, qrProdaja_tovara);
        }

        public void dtRoleFill()
        {
            dtFill(dtRole, qrRole);
        }

        public void dtSoiskatelFill()
        {
            dtFill(dtSoiskatel, qrSoiskatel);
        }
        public void dtSotrudnikFill()
        {   
            dtFill(dtSotrudnik, qrSotrudnik);
        }

        public void dtTabel_rab_vremeniFill()
        {
            dtFill(dtTabel_rab_vremeni, qrTabel_rab_vremeni);
        }

        public void dtTabel_zarplataFill()
        {
            dtFill(dtTabel_zarplata, qrTabel_zarplata);
        }

        public void dtTovar_na_skladeFill()
        {
            dtFill(dtTovar_na_sklade, qrTovar_na_sklade);
        }

        public void dtVih_docFill()
        {
            dtFill(dtVih_doc, qrVih_doc);
        }

        public void dtTr_pribil_i_rashodiFill()
        {
            dtFill(dtTr_pribil_i_rashodi, qrTr_pribil_i_rashodi);
        }
    }
}

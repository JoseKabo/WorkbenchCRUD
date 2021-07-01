using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkbenchCRUD
{
    public partial class Form1 : Form
    {
        ConnectionWithQuery obj;
        public int _id;
        private void LoadData(DataTable newData, int tabIndex = 0)
        {
            if( newData!= null && tabIndex >= 0)
            {

            switch ( tabIndex)
            {
                case 0:
                    dataGridView1.DataSource = newData;
                    break;
                case 1:
                    dataGridView2.DataSource = newData;
                    break;
                    case 9:
                        dgv_pacientes_act.DataSource = newData;
                        dgv_pacientes_consulta.DataSource = newData;
                        break;
            }
                
            }
        }

        private string buildQuery(string type)
        {
            string build = "";
            switch (type)
            {
                case "paciente":
                    build = "CALL new_paciente(@name, @nss, @birthday, @adress, @country, @phone, @genre)";
                    break;
                case "consulta":
                    build = "CALL new_consulta(@observaciones, @fecha, @datos_interes, @diagnostico, @id_paciente, @detalle_tratamiento)";
                    break;
                case "eliminar":
                    build = "CALL drop_paciente(@id_paciente)";
                    break;
                case "actualizar":
                    build = "CALL alter_paciente(@adress, @country, @phone, @id)";
                    break;
                default:
                    break;
            }
            return build;
        }

        private List<MySqlParameter> setParameters(List<ParametersModel> parameters )
        {
            List<MySqlParameter> mySqlParameters = new List<MySqlParameter>();
            foreach (var item in parameters)
            {
               
                    mySqlParameters.Add(new MySqlParameter
                    {
                        ParameterName = item.name,
                        Value = item.value,
                        Direction = ParameterDirection.Input
                    });
                
            }
            return mySqlParameters;
        }

        private List<ParametersModel> GetInfo(string type)
        {
            List<ParametersModel> parameters = new List<ParametersModel>();
            switch (type)
            {
                case "paciente":
                    parameters.Add(new ParametersModel("@name", txt_name.Text, MySqlDbType.VarChar));
                    parameters.Add(new ParametersModel("@nss", txt_nss.Text, MySqlDbType.VarChar));
                    parameters.Add(new ParametersModel("@birthday", dtp_birthday.Value.ToString("yyyy-MM-dd"), MySqlDbType.Date));
                    parameters.Add(new ParametersModel("@adress", txt_adress.Text, MySqlDbType.VarChar));
                    parameters.Add(new ParametersModel("@country", txt_country.Text, MySqlDbType.VarChar));
                    parameters.Add(new ParametersModel("@phone", txt_phone.Text, MySqlDbType.VarChar));
                    parameters.Add(new ParametersModel("@genre", txt_genre.Text, MySqlDbType.VarChar));
                    break;
                case "consulta":
                    parameters.Add(new ParametersModel("@observaciones", txt_observaciones.Text, MySqlDbType.VarChar));
                    parameters.Add(new ParametersModel("@fecha", dtp_fecha_consulta.Value.ToString("yyyy-MM-dd"), MySqlDbType.Date));
                    parameters.Add(new ParametersModel("@datos_interes", txt_datos.Text, MySqlDbType.VarChar));
                    parameters.Add(new ParametersModel("@diagnostico", txt_diagnostico.Text, MySqlDbType.VarChar));
                    parameters.Add(new ParametersModel("@id_paciente", _id, MySqlDbType.Int32));
                    parameters.Add(new ParametersModel("@detalle_tratamiento", txt_tratamiento.Text, MySqlDbType.VarChar));
                    break;
                case "eliminar":
                    parameters.Add(new ParametersModel("@id_paciente", _id, MySqlDbType.Int32));
                    break;
                case "actualizar":
                    parameters.Add(new ParametersModel("@adress", txt_adress_act.Text, MySqlDbType.VarChar));
                    parameters.Add(new ParametersModel("@country", txt_country_act.Text, MySqlDbType.VarChar));
                    parameters.Add(new ParametersModel("@phone", txt_phone_act.Text, MySqlDbType.VarChar));
                    parameters.Add(new ParametersModel("@id", _id, MySqlDbType.VarChar));
                    break;
                default:
                    break;
            }

            return parameters;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.obj = new ConnectionWithQuery("SELECT * FROM PACIENTES", "get");
            this.LoadData(this.obj.executeQuery(), 0);
            this.dgv_pacientes_consulta.ClearSelection();
            this.dgv_pacientes_act.ClearSelection();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    this.obj = new ConnectionWithQuery("SELECT * FROM PACIENTES", "get");
                    this.LoadData(this.obj.executeQuery(), tabControl1.SelectedIndex);
                    break;
                case 1:
                    this.obj = new ConnectionWithQuery("SELECT * FROM consultas", "get");
                    this.LoadData(this.obj.executeQuery(), tabControl1.SelectedIndex);
                    break;
                default:
                    this.obj = new ConnectionWithQuery("SELECT * FROM PACIENTES", "get");
                    this.LoadData(this.obj.executeQuery(), 9);
                    break;
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            List<ParametersModel> info = this.GetInfo("paciente");
            List<MySqlParameter> parameters = this.setParameters(info);
            string query = this.buildQuery("paciente");

            this.obj = new ConnectionWithQuery(query, "post", parameters);
            this.obj.executeQuery();
        }

        private void dgv_pacientes_consulta_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_pacientes_consulta.SelectedRows.Count > 0)
            {
                _id = Convert.ToInt32(dgv_pacientes_consulta.SelectedRows[0].Cells["id"].Value.ToString());
            }
        }

        private void dgv_pacientes_act_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_pacientes_act.SelectedRows.Count > 0)
            {
                _id = Convert.ToInt32(dgv_pacientes_act.SelectedRows[0].Cells["id"].Value.ToString());
                txt_adress_act.Text = dgv_pacientes_act.SelectedRows[0].Cells["adress"].Value.ToString();
                txt_name_act.Text = dgv_pacientes_act.SelectedRows[0].Cells["name"].Value.ToString();
                txt_country_act.Text = dgv_pacientes_act.SelectedRows[0].Cells["country"].Value.ToString();
                txt_nss_act.Text = dgv_pacientes_act.SelectedRows[0].Cells["nss"].Value.ToString();
                dtp_fecha_act.Value = DateTime.Parse(dgv_pacientes_act.SelectedRows[0].Cells["birthday"].Value.ToString());
                txt_phone_act.Text = dgv_pacientes_act.SelectedRows[0].Cells["phone"].Value.ToString();
                txt_genre_act.Text = dgv_pacientes_act.SelectedRows[0].Cells["genre"].Value.ToString();
            }
        }

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            List<ParametersModel> info = this.GetInfo("eliminar");
            List<MySqlParameter> parameters = this.setParameters(info);
            string query = this.buildQuery("eliminar");

            this.obj = new ConnectionWithQuery(query, "delete", parameters);
            this.obj.executeQuery();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value.ToString());
            }
        }

        private void btn_save_consulta_Click(object sender, EventArgs e)
        {
            List<ParametersModel> info = this.GetInfo("consulta");
            List<MySqlParameter> parameters = this.setParameters(info);
            string query = this.buildQuery("consulta");

            this.obj = new ConnectionWithQuery(query, "post", parameters);
            this.obj.executeQuery();
        }
    }

    public class ParametersModel
    {
        public string name { get; set; }
        public object value { get; set; }
        public MySqlDbType type {get; set;}
        public ParametersModel(string name, object value, MySqlDbType type)
        {
            this.name = name;
            this.type = type;
            this.value = value;
        }
    }

    public class ConnectionWithQuery
    {
        public static string endpointdb = "datasource=localhost;port=3306;username=root;password=mcKabo060699*.;database=practica_tempis;";
        MySqlConnection databaseConnection;
        public MySqlDataReader reader;
        string _query { get; set; }
        string _method { get; set; }
        bool _isSP { get; set; }
        List<MySqlParameter> _parameters;
        public ConnectionWithQuery(string query, string method, List<MySqlParameter> paramerters = null, bool isSP = false)
        {
            this._query = query;
            this._method = method;
            this._parameters = paramerters;
            this._isSP = isSP;
        }
        public DataTable executeQuery()
        {
            DataTable dt = new DataTable();
            if (connect() != null)
            {
                Console.WriteLine("Success connection");
                if( this._query.Length > 0 && this._method.Length > 0 )
                {
                    MySqlCommand commandDatabase = new MySqlCommand(this._query, this.connect());
                    commandDatabase.CommandTimeout = 60;
                    try
                    {
                        switch (this._method)
                        {
                            case "get":
                                    this.reader = commandDatabase.ExecuteReader();
                                    break;
                            case "post":
                                foreach (var item in this._parameters)
                                {
                                    commandDatabase.Parameters.Add(item);
                                }
                                reader = commandDatabase.ExecuteReader();
                                MessageBox.Show("Se inserto correcto");
                                Console.WriteLine("Result:" + reader.ToString());
                                break;
                            case "update":
                                commandDatabase.Parameters.Add(this._parameters);
                                reader = commandDatabase.ExecuteReader();
                                    Console.WriteLine("Result:" + reader.ToString());
                                    MessageBox.Show("Se actualizo correcto");
                                    break;
                            case "delete":
                                foreach (var item in this._parameters)
                                {
                                    commandDatabase.Parameters.Add(item);
                                }
                                reader = commandDatabase.ExecuteReader();
                                Console.WriteLine("Result:" + reader.ToString());
                                    MessageBox.Show("Se elimino correcto");
                                    break;
                        }

                    }   
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception is: " + e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error de conexion");
            }
            if ( this._method.Equals("get"))
            {
                dt.Load(reader);
            }
            return dt;
        }

        private MySqlConnection connect()
        {
            try
            {
                databaseConnection = new MySqlConnection(endpointdb);
                databaseConnection.Open();
                return databaseConnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void CloseConnection()
        {
            this.databaseConnection.Close();
        }
    }
}

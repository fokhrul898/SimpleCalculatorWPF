using SimpleCalculator.Conveters;
using SimpleCalculator.DbContexts;
using SimpleCalculator.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SimpleCalculator.Models
{
    public class CalculatorService :ICalculator
    {
        private static List<Calculator> calculators;
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dt;


        public CalculatorService()
        {
            calculators = new List<Calculator>();
            connection = new SqlConnection(CalculatorDBContext.connectionString);
        } 

        public List<Calculator> GetAll()
        {
            try
            {
                command = new SqlCommand("SPGetCalculatorData", connection);
                command.CommandType = CommandType.StoredProcedure;

                if (connection.State != ConnectionState.Open) { connection.Open(); }
                adapter = new SqlDataAdapter(command);

                dt = new DataTable();
                adapter.Fill(dt);
                calculators = (DataTableToListConverter.TableToList<Calculator>(dt));
               
                connection.Close();
                return calculators;
            }
            // for Eeception Handeling
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool TruncateCalculatorHistoryTable()
        {
            try
            {
                command = new SqlCommand("SPTruncateCalculatorTable", connection);
                command.CommandType = CommandType.StoredProcedure;

                if (connection.State != ConnectionState.Open) { connection.Open(); }
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            // for Exception Handling
            catch
            {
                return false;
            }
            finally
            {
            }
        }

        public bool Add(Calculator calculator)
        {
            try
            {
                command = new SqlCommand("SPSaveCalculatorData", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@SummationOfNumberValue", SqlDbType.NVarChar).Value = calculator.SummationOfNumberValue;
                command.Parameters.Add("@Result", SqlDbType.Decimal).Value = calculator.Result;
                if (connection.State != ConnectionState.Open) { connection.Open(); }
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            // for Exception Handling
            catch
            {
                return false;
            }
            finally
            {

            }
        }

        public bool Update(Calculator calculator)
        {
            try
            {
                command = new SqlCommand("SPUpdateCalculatorData", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Id", SqlDbType.Int).Value = calculator.Id;
                command.Parameters.Add("@SummationOfNumberValue", SqlDbType.NVarChar).Value = calculator.SummationOfNumberValue;
                command.Parameters.Add("@Result", SqlDbType.NVarChar).Value = calculator.Result;
                if (connection.State != ConnectionState.Open) { connection.Open(); }
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            // for Exception Handling
            catch
            {
                return false;
            }
            finally
            {

            }

        }


    }
}

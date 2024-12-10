using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Entidades.Final
{
    public static class Manejadora
    {
        /// <summary>
        /// Maneja el evento de un apellido existente, escribiendo un log en un archivo.
        /// </summary>
        public static void Manejador_ApellidoExistenteLog(object sender, ApellidoUsuarioExistenteEventArgs e)
        {
            try
            {
                // Llamar al método que escribe el archivo con la lista de usuarios
                bool resultado = EscribirArchivo(e.Usuarios);

                if (!resultado)
                    Console.WriteLine("Error al escribir el archivo log.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en Manejador_ApellidoExistenteLog: {ex.Message}");
            }
        }

        /// <summary>
        /// Escribe un archivo de log acumulativo en la carpeta 'Mis Documentos'.
        /// </summary>
        /// <param name="usuarios">La lista de usuarios cuyos apellidos coinciden.</param>
        /// <returns>True si se escribió correctamente; de lo contrario, false.</returns>
        public static bool EscribirArchivo(List<Usuario> usuarios)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "usuarios.log");

            try
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")); // Fecha y hora
                    string apellido = usuarios.First().Apellido; // Usar el apellido del primer usuario
                    sw.WriteLine($"Apellido: {apellido}");

                    // Escribir todos los correos electrónicos separados por comas
                    string correos = string.Join(", ", usuarios.Select(u => u.Correo));
                    sw.WriteLine($"Correos: {correos}");
                    sw.WriteLine(); // Línea en blanco para separar entradas
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Maneja el evento de un apellido existente, serializando a JSON la lista de usuarios.
        /// </summary>
        public static void Manejador_ApellidoExistenteJSON(object sender, ApellidoUsuarioExistenteEventArgs e)
        {
            try
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "usuarios_repetidos.json");

                // Llamar al método que serializa a JSON
                bool resultado = SerializarJSON(e.Usuarios, path);

                if (!resultado)
                    Console.WriteLine("Error al serializar el archivo JSON.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en Manejador_apellidoExistenteJSON: {ex.Message}");
            }
        }

        /// <summary>
        /// Serializa una lista de usuarios a un archivo JSON.
        /// </summary>
        /// <param name="usuarios">La lista de usuarios a serializar.</param>
        /// <param name="path">La ruta del archivo donde se guardará el JSON.</param>
        /// <returns>True si se serializó correctamente; de lo contrario, false.</returns>
        public static bool SerializarJSON(List<Usuario> usuarios, string path)
        {
            try
            {
                string json = JsonSerializer.Serialize(usuarios, new JsonSerializerOptions
                {
                    WriteIndented = true // Formatear JSON con indentación
                });

                // Escribir el JSON en el archivo
                File.WriteAllText(path, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Deserializa un archivo JSON a una lista de usuarios.
        /// </summary>
        /// <param name="path">Ruta del archivo JSON a deserializar.</param>
        /// <param name="usuarios">Lista deserializada de usuarios.</param>
        /// <returns>True si la operación fue exitosa; de lo contrario, false.</returns>
        public static bool DeserializarJSON(string path, out List<Usuario> usuarios)
        {
            usuarios = new List<Usuario>();

            try
            {
                // Leer el contenido del archivo JSON
                string json = File.ReadAllText(path);

                // Deserializar a una lista de Usuario
                usuarios = JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();

                // Retornar true si la lista se deserializó correctamente
                return usuarios.Count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al deserializar JSON: {ex.Message}");
                return false;
            }
        }
    }
}

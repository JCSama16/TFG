using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Exceptions;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;
using MySql.Data.MySqlClient;
using System.Data;
using LibVLCSharp.WinForms;
using LibVLCSharp.Shared;
using System.Drawing;

namespace TFG
{

    public partial class Form1 : Form
    {
        private readonly YoutubeDownloader youtubeDownloader;

        private VideoConverter videoConverter;

        private Reproductor_Multimedia _reproductor;

        private VideoView _videoView;

        string server = "localhost";
        string port = "3306";
        string dataBase = "descargas";
        string usuario = "root";
        string contrasenia = "Jc825379";

        public Form1()
        {
            InitializeComponent();
            youtubeDownloader = new YoutubeDownloader(progressBar1);

            videoConverter = new VideoConverter();

            // Inicializa Reproductor_Multimedia
            _reproductor = new Reproductor_Multimedia();

            // Configura VideoView
            _reproductor.ConfigureVideoView(Reproductor);

            Reproductor.MediaPlayer = _reproductor.GetMediaPlayer();

            // Opcional: Reproduce un video al cargar la aplicación
            //_reproductor.PlayVideo("C:\\Users\\Tecnicos\\Videos\\TFG\\JOSE REY - BÉSAME - JOSE REY OFICIAL.mp4");

            //InitializeVideoView();
            SetupButtons();


            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);
            CombFiltro.SelectedIndexChanged += new EventHandler(CombFiltro_SelectedIndexChanged);

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Solo carga datos si la pestaña seleccionada es la pestaña de "Descargas"
            if (tabControl1.SelectedTab == tabPage2)
            {
                LoadData();
            }
        }

        private void CombFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Carga datos basado en el filtro seleccionado
            LoadData(CombFiltro.SelectedItem.ToString());
        }

        private void LoadData(string filtro = "Todos")
        {
            string connectionString = "Server=" + server + ";port=" + port + ";Database=" + dataBase + ";User ID=" + usuario + ";Password=" + contrasenia + ";";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Abre la conexión
                    conn.Open();

                    // Define la consulta con filtro
                    string query = "SELECT Titulo, Artista, Tipo, FechaDescarga as 'Fec. Descarga', Ubicación FROM descargasyt";
                    if (filtro != "Todos")
                    {
                        query += " WHERE Tipo = @Filtro";
                    }

                    // Crea un adaptador de datos
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);

                    // Si hay filtro, añade el parámetro
                    if (filtro != "Todos")
                    {
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@Filtro", filtro);
                    }

                    // Crea y llena un DataTable
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Asigna el DataTable como fuente de datos del DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private async void btn_Descargar_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text; // Obtiene la URL del TextBox1
            string rutaCarpeta = textBox2.Text; // Obtiene la ruta de la carpeta del TextBox2
            string tipo = CombTipo.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(url) || string.IsNullOrWhiteSpace(rutaCarpeta))
            {
                MessageBox.Show("Por favor, completa tanto la URL como la carpeta de destino.");
                return;
            }

            try
            {
                // Descargar video
                await youtubeDownloader.DownloadVideoAsync(url, rutaCarpeta, tipo);
                MessageBox.Show("La descarga ha terminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al descargar el video: {ex.Message}");
            }
        }

        private void btn_Ruta_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    textBox2.Text = dialog.SelectedPath; // Asigna la ruta seleccionada al TextBox2
                }
            }
        }

        private async void btn_CargarCalidades_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            try
            {
                var availableQualities = await youtubeDownloader.GetAvailableQualitiesAsync(url);
                comboBox1.DataSource = availableQualities;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las calidades: {ex.Message}");
            }
        }

        private void buttonSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Archivos de vídeo|*.mp4;*.avi;*.mov;*.mkv;*.wmv";
                dialog.Title = "Seleccionar archivo de vídeo";

                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    textBoxArchivo.Text = dialog.FileName;
                }
            }
        }

        private void Btn_RutaSalida_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Seleccionar carpeta de salida";

                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    textBoxSalida.Text = dialog.SelectedPath;
                }
            }
        }

        private void buttonConvertir_Click(object sender, EventArgs e)
        {
            string rutaVideo = textBoxArchivo.Text;

            string rutaSalidaMp3 = textBoxSalida.Text;

            if (string.IsNullOrWhiteSpace(rutaVideo) || string.IsNullOrWhiteSpace(rutaSalidaMp3))
            {
                MessageBox.Show("Por favor, selecciona tanto el archivo de video como la ruta de salida.");
                return;
            }

            try
            {
                if (!File.Exists(rutaVideo))
                {
                    MessageBox.Show("El archivo de video no existe. Por favor, verifica la ruta.");
                    return;
                }

                string directoryPath = Path.GetDirectoryName(rutaSalidaMp3);
                if (!Directory.Exists(directoryPath))
                {
                    MessageBox.Show("La carpeta de salida no existe. Por favor, verifica la ruta.");
                    return;
                }

                string mp3FileName = Path.GetFileNameWithoutExtension(rutaVideo) + ".mp3";
                string archivoMp3 = Path.Combine(rutaSalidaMp3, mp3FileName);

                videoConverter.ConvertToMp3(rutaVideo, archivoMp3);
                MessageBox.Show("Conversión completada con éxito.");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante la conversión: " + ex.Message);
            }
        }

        /*private void InitializeVideoView()
        {
            _videoView = new VideoView
            {
                Dock = DockStyle.Fill
            };
            tabPage4.Controls.Add(_videoView);
            _reproductor.ConfigureVideoView(_videoView);
        }*/

        private void SetupButtons()
        {
            // Assuming you have added these buttons in the designer and named them appropriately
            buttonPlay.Click += ButtonPlay_Click;
            buttonPause.Click += ButtonPause_Click;
            buttonStop.Click += ButtonStop_Click;
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Media Files|*.mp4;*.mkv;*.avi;*.mov;*.flv"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _reproductor.PlayVideo(openFileDialog.FileName);
            }
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            _reproductor.PauseVideo();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            _reproductor.StopVideo();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Libera recursos
            _reproductor.Dispose();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica quela columna y la fila son validas.
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtiene la ruta del archivo de la columna "Ubicación"
                var filePath = dataGridView1.Rows[e.RowIndex].Cells["Ubicación"].Value?.ToString();

                if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                {
                    // Cambia a la pestaña del reproductor
                    tabControl1.SelectedTab = tabPage4;

                    // Reproduce el video
                    _reproductor.PlayVideo(filePath);
                }
                else
                {
                    MessageBox.Show("El archivo de video no existe o la ruta es inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }



    public class YoutubeDownloader
    {

        string server = "localhost";
        string port = "3306";
        string dataBase = "descargas";
        string usuario = "root";
        string contrasenia = "Jc825379";

        private readonly System.Windows.Forms.ProgressBar progressBar; // Calificar el tipo ProgressBar
        private readonly YoutubeClient youtubeClient;
        public List<string> AvailableQualities { get; private set; }


        public YoutubeDownloader(System.Windows.Forms.ProgressBar progressBar)
        {
            this.progressBar = progressBar; // Calificar el tipo ProgressBar
            this.youtubeClient = new YoutubeClient();
        }

        public async Task DownloadVideoAsync(string videoUrl, string outputDirectory, string tipo)
        {
            try
            {
                var videoId = YoutubeExplode.Videos.VideoId.Parse(videoUrl);
                var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(videoId);

                var muxedStreams = streamManifest.GetMuxedStreams().ToList(); // Convierte a una lista
                if (!muxedStreams.Any())
                {
                    throw new Exception("No se encontró un formato de video disponible.");
                }

                // Ordena los flujos por calidad (resolución):

                //Busca la mejor resolucion del video
                //var streamInfo = muxedStreams.OrderByDescending(s => s.VideoResolution.Height).First();

                //Busca la mejor resolución del video con audio
                //var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

                //Busca la mejor de las mejores resoluciones pero sin audio.
                /*var streamInfo = streamManifest
                    .GetVideoOnlyStreams()
                    .Where(s => s.Container == Container.Mp4)
                    .GetWithHighestVideoQuality();*/

                var streamInfo = streamManifest
                    .GetMuxedStreams()
                    .Where(s => s.Container == Container.Mp4)
                    .GetWithHighestVideoQuality();

                // Obtenemos el título del video y del artista
                var video = await youtubeClient.Videos.GetAsync(videoId);
                var videoInfo = new VideoInfo
                {
                    Title = video.Title,
                    Artist = video.Author.ChannelTitle,
                    Description = video.Description,
                    Duration = video.Duration ?? TimeSpan.Zero,
                    DownloadDate = DateTime.Now,
                    Tipo = tipo,
                    Ubicacion = ""

                };
                var tituloVideo = video.Title;
                var artista = video.Author;
                

                // Creacion del nombre del archivo de salida
                var outputFile = Path.Combine(outputDirectory, $"{tituloVideo} - {artista}.{streamInfo.Container}");

                var progressHandler = new Progress<double>(progress =>
                {
                    // Actualiza el valor del ProgressBar con el progreso de la descarga                    
                    progressBar.Value = (int)Math.Round(progress * 100);
                });

                await youtubeClient.Videos.Streams.DownloadAsync(streamInfo, outputFile, progressHandler);
                Console.WriteLine($"Video descargado: {outputFile}");

                // Llamada a InsertDownloadInfoAsync después de la descarga exitosa
                videoInfo.Ubicacion = outputFile;
                await InsertDownloadInfoAsync(videoInfo);
            }
            catch (VideoUnplayableException)
            {
                throw new Exception("El video no está disponible.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al descargar el video: {ex.Message}");
                throw;
            }
        }

        public async Task<List<string>> GetAvailableQualitiesAsync(string videoUrl)
        {
            try
            {
                var videoId = VideoId.Parse(videoUrl);
                var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(videoId);
                var muxedStreams = streamManifest.GetMuxedStreams().ToList();

                // Depurar información sobre los flujos de video
                Console.WriteLine($"Número de flujos de video encontrados: {muxedStreams.Count}");
                foreach (var stream in muxedStreams)
                {
                    Console.WriteLine($"Calidad del flujo: {stream.VideoQuality}");
                }

                // Obtener calidades únicas y devolver la lista
                AvailableQualities = muxedStreams.Select(s => s.VideoQuality.ToString()).Distinct().ToList();
                return AvailableQualities;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las calidades del video: {ex.Message}");
                throw;
            }
        }

        public async Task InsertDownloadInfoAsync(VideoInfo videoInfo)
        {
            string connectionString = "Server="+server+";port="+port+";Database="+dataBase+";User ID="+usuario+";Password="+contrasenia+";";


            using (var connection = new MySqlConnection(connectionString))
            {

                await connection.OpenAsync();

                var query = @"INSERT INTO Descargasyt (Titulo, Artista, Descripcion, Duracion, FechaDescarga, Tipo, Ubicación) 
                      VALUES (@Titulo, @Artista, @Descripcion, @Duracion, @FechaDescarga, @Tipo, @Ubicacion)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Titulo", videoInfo.Title);
                    command.Parameters.AddWithValue("@Artista", videoInfo.Artist);
                    command.Parameters.AddWithValue("@Descripcion", videoInfo.Description);
                    command.Parameters.AddWithValue("@Duracion", videoInfo.Duration);
                    command.Parameters.AddWithValue("@FechaDescarga", videoInfo.DownloadDate);
                    command.Parameters.AddWithValue("@Tipo", videoInfo.Tipo);
                    command.Parameters.AddWithValue("@Ubicacion", videoInfo.Ubicacion);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        // Se usa para obtener la información del video sin necesidad de descargarlo, por ahora no lo vamos a usar
        public async Task<VideoInfo> GetVideoInfoAsync(string videoUrl)
        {
            try
            {
                var videoId = VideoId.Parse(videoUrl);
                var video = await youtubeClient.Videos.GetAsync(videoId);

                // Obtener los metadatos del video
                var videoTitle = video.Title;
                var artist = video.Author.ChannelTitle;
                var description = video.Description;
                var duration = video.Duration;
                var downloadDate = DateTime.Now; // Fecha de descarga

                // Devolver la información del video
                return new VideoInfo
                {
                    Title = videoTitle,
                    Artist = artist.ToString(),
                    Description = description,
                    Duration = video.Duration ?? TimeSpan.Zero,
                    DownloadDate = downloadDate
                };
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la obtención de la información del video
                Console.WriteLine($"Error al obtener la información del video: {ex.Message}");
                throw;
            }
        }
    }
}

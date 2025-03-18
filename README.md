# Tres en Raya - .NET MAUI

## Descripción
Este es un proyecto de juego **Tres en Raya** desarrollado con **.NET MAUI**. La interfaz de usuario está diseñada en **XAML**, utilizando una cuadrícula de botones para representar el tablero del juego.

## Características
- **Interfaz simple y elegante** con degradado en el fondo.
- **Estilo personalizado** para los botones del tablero.
- **Diseño adaptable** usando Grid para una mejor organización.
- **Eventos de clic en los botones** para manejar la lógica del juego.

## Requisitos
- **.NET MAUI** instalado en tu sistema.
- **Visual Studio 2022** con las herramientas para desarrollo en MAUI.

## Instalación y ejecución
```bash
# Clona el repositorio
git clone https://github.com/tu_usuario/tres_en_raya_maui.git

# Accede al directorio del proyecto
cd tres_en_raya_maui

# Abre el proyecto en Visual Studio
dotnet build

# Ejecuta la aplicación
dotnet run
```

## Estructura del Proyecto
```plaintext
📂 tres_en_raya
 ├── 📁 Platforms/          # Configuración específica para cada plataforma
 ├── 📁 Resources/          # Archivos de recursos como imágenes y estilos
 ├── 📁 Views/              # Vistas en XAML
 ├── 📁 Models/             # Modelos de datos (si se usan)
 ├── 📁 ViewModels/         # Lógica de negocio (si se usa MVVM)
 ├── 📄 MainPage.xaml       # Interfaz principal del juego
 ├── 📄 MainPage.xaml.cs    # Código detrás de la interfaz
 ├── 📄 App.xaml            # Configuración global de estilos
 ├── 📄 App.xaml.cs         # Configuración de la aplicación
 ├── 📄 Program.cs          # Punto de entrada de la aplicación
 ├── 📄 README.md           # Archivo de documentación
 └── 📄 index.md            # Archivo para GitHub Pages
```

## Publicación en GitHub Pages
```bash
# Asegúrate de que tu repositorio sea público
git remote add origin https://github.com/tu_usuario/tres_en_raya.git
git push -u origin main

# Crea un archivo index.md con el contenido de README.md
cp README.md index.md

git add index.md
git commit -m "Agregado index.md para GitHub Pages"
git push origin main
```
Luego, en **Settings > Pages** en GitHub, selecciona la rama `main` y la carpeta raíz. Después de unos minutos, tu documentación estará disponible en:
```plaintext
https://tu_usuario.github.io/tres_en_raya/
```

## Contribución
```bash
# Haz un fork del proyecto
git fork https://github.com/tu_usuario/tres_en_raya.git

# Crea una nueva rama
git checkout -b feature-nueva

# Realiza cambios y haz un commit
git commit -am "Agregada nueva funcionalidad"

# Sube los cambios
git push origin feature-nueva

# Abre un Pull Request en GitHub
```

## Contacto
Si tienes preguntas o sugerencias, contáctame en: **[tu_email@example.com](mailto:santiagonoguera2200@gmail.com)**


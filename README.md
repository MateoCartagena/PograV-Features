# PrograV-Features
## LINK
https://udlaec.sharepoint.com/:v:/s/Videos956/EUpVu_IcTLxOiqtEqkRKFjUB59USi_TcSTxFraO_oeC9eA?e=PBCUO8&nav=eyJyZWZlcnJhbEluZm8iOnsicmVmZXJyYWxBcHAiOiJTdHJlYW1XZWJBcHAiLCJyZWZlcnJhbFZpZXciOiJTaGFyZURpYWxvZy1MaW5rIiwicmVmZXJyYWxBcHBQbGF0Zm9ybSI6IldlYiIsInJlZmVycmFsTW9kZSI6InZpZXcifX0%3D
## Features

Drag and Drop:

Permite a los usuarios mover objetos en la escena del juego arrastrándolos con el mouse.
La clase DragAndDrop que proporcionaste implementa esta funcionalidad.
En el código, rastrea la posición del mouse, calcula la posición del objeto en la pantalla y actualiza la posición del objeto en el mundo en consecuencia.
Boundaries:

Definen los límites físicos del movimiento de los objetos en la escena.
El código PlayerController2 que proporcionaste implementa límites para restringir el movimiento del jugador.
Utiliza variables como xRange y zRange para establecer los límites horizontales y verticales.
En la función Update(), comprueba si el jugador ha sobrepasado los límites y, de ser así, lo coloca de nuevo dentro de ellos.
Video player:

Reproduce videos dentro de la escena del juego.
La clase VideoController que proporcionaste controla la reproducción de videos.
Utiliza un VideoPlayer para reproducir videos y puede cambiar entre diferentes videos cuando se alcanza un punto de bucle.
Splash image:

Una imagen que se muestra al inicio del juego, generalmente antes de que se cargue la escena principal.
En Unity, puedes configurar una imagen de bienvenida a través de las opciones de Player Settings.
Se utiliza comúnmente para mostrar logotipos, información de la empresa o pantallas de carga.

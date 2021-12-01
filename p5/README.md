Este archivo `README.md` debe estar en la ra铆z de la carpeta abierta en Visual Studio Code; en caso contrario deben usar el comando **File|Open Folder...** para abrir la carpeta que lo contiene.

En este problema deben demostrar que conocen el patr贸n Polymorphism Sean las siguientes tarjetas CRC de las clases `MaterialType` y `Material`:

<table id="card">
    <tr>
        <td align="center" colspan="2">
            <p><b>MaterialType</b></p>
        </td>
    </tr>
    <tr>
        <td>
            <p>Conocer el nombre del tipo de material</p>
            <p>Conocer si el tipo de material es peligroso o no</p>
        </td>
        <td>
            <p>MaterialType</p>
        </td>
    </tr>
</table>


<table id="card">
    <tr>
        <td align="center" colspan="2">
            <p><b>Material</b></p>
        </td>
    </tr>
    <tr>
        <td>
            <p>Conocer el nombre del material</p>
            <p>Conocer el tipo del material</p>
            <p>Determinar si dos materiales son iguales</p>
        </td>
        <td>
            <p>MaterialType</p>
        </td>
    </tr>
</table>

頎巾病 Dos materiales son iguales sin tienen el mismo `MaterialType` y el mismo valor en la propiedad `Name` con la que se implementa la responsabilidad de conocer el nombre del material.

**Consigna:**

Dadas estas tarjetas CRC y el c贸digo correspondiente en las carpetas `src` y `test`, completar el c贸digo que falta para:

1. Analizar si la operaci贸n que determinar si dos objetos son iguales es correcta o no
2. Que pasen todos los casos de prueba provistos

鈿狅笍 No deben modificar los casos de prueba.

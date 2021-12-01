Este archivo `README.md` debe estar en la ra铆z de la carpeta abierta en Visual Studio Code; en caso contrario deben usar el comando **File|Open Folder...** para abrir la carpeta que lo contiene.

En este problema deben demostrar que saben c贸mo distribuir responsabilidades utilizando el patr贸n Expert.

Sean las siguientes tarjetas CRC de las clases `Publication` y `PublicationItem`:

<table id="card">
    <tr>
        <td align="center" colspan="2">
            <p><b>Publication</b></p>
        </td>
    </tr>
    <tr>
        <td>
            <p>Conocer la fecha final de la publicaci贸n</p>
            <p>Conocer los 铆tems publicados y agregar y remover 铆tems a la publicaci贸n</p>
            <p>Obtener el texto de la publicaci贸n para mostrar</p>
        </td>
        <td>
            <p>PublicationItem</p>
        </td>
    </tr>
</table>

El texto de la publicaci贸n luce as铆:
```bash
Fecha: 31/3/2021
1 de 'Caja de cart贸n' a $23
4 de 'Placa de cart贸n' a $56
```

頎巾病 El formato preciso del texto de la publicaci贸n no es importante **en la medida que incluya para cada 铆tem publicado la cantidad, el nombre del material y el precio**. Noten que la cantidad y el precio son responsabilidades de la clase `PublicationItem` y el nombre del material es una responsabilidad de conocer de la clase `Material`.

<table id="card">
    <tr>
        <td align="center" colspan="2">
            <p><b>PublicationItem</b></p>
        </td>
    </tr>
    <tr>
        <td>
            <p>Conocer el material publicado</p>
            <p>Conocer la cantidad del material</p>
            <p>Conocer el precio del material</p>
        </td>
        <td>
            <p>Material</p>
        </td>
    </tr>
</table>

**Consigna:**

Dadas estas tarjetas CRC y el c贸digo correspondiente en las carpetas `src` y `test`, completar el c贸digo que falta para:

1. Determinar qu茅 clase debe tener la responsabilidad de conocer el costo total de una publicaci贸n.
2. Que pasen todos los casos de prueba provistos

鈿狅笍 No deben modificar los casos de prueba.

頎巾病 El costo total de una publicaci贸n se calcula como la suma de los sub totales de sus 铆tems, y el sub total de un 铆tem
se calculo como el producto de la cantidad por el precio del 铆tem.
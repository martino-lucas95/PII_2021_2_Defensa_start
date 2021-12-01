Este archivo `README.md` debe estar en la raíz de la carpeta abierta en Visual Studio Code; en caso contrario deben usar el comando **File|Open Folder...** para abrir la carpeta que lo contiene.

En este problema deben demostrar que saben cómo aplicar el principio de inversión de dependencias para que la clase concreta `Publication` no dependa de otra clase concreta `PublicationItem` sino de una abstracción `IPublicationItem`.

Eso va a permitir que una publicación tenga descuentos además de ítems. Los descuentos restan un importe fijo al total de la publicación. Además de las clases `Publication` y `PublicationItem` de los ejercicios anteriores ahora hay una clase `PublicationDiscount`:

<table id="card">
    <tr>
        <td align="center" colspan="2">
            <p><b>PublicationDiscount</b></p>
        </td>
    </tr>
    <tr>
        <td>
            <p>Conocer el importe a descontar</p>
        </td>
    </tr>
</table>

Desde que el descuento se debe restar al total de la publicación, hay una precondición que **el importe del descuento debe ser estrictamente negativo** tanto al crear una instancia de `PublicationDiscount` y como al modificarlo.

La clase `Publication` se modifica para conocer y operar indistintamente con ítems como con descuentos.

<table id="card">
    <tr>
        <td align="center" colspan="2">
            <p><b>Publication</b></p>
        </td>
    </tr>
    <tr>
        <td>
            <p>Conocer la fecha final de la publicación</p>
            <p>Conocer los ítems o descuentos publicados y agregar y remover ítems o descuentos a la publicación</p>
            <p>Conocer el total de la publicación</p>
        </td>
        <td>
            <p>PublicationItem</p>
        </td>
    </tr>
</table>

**Consigna:**

Dadas estas tarjetas CRC y el código correspondiente en las carpetas `src` y `test`, completar el código que falta para:

1. Modificar la clase `Publication` para que dependa de la abstracción `IPublicationItem`
2. Modificar la clase `PublicationItem` para que sea una implementación concreta de la abstracción `IPublicationItem`
3. Completar la clase `PublicationDiscount` para que sea otra implementación concreta de la abstracción `IPublicationItem`
4. Implementar las precondiciones en `PublicationDiscount` usando `ArgumentException`
5. Que pasen todos los casos de prueba provistos.

⚠️ No deben modificar los casos de prueba.
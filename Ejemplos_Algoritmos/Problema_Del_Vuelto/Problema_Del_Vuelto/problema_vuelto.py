import sys

Monedas_Para_Vuelto: list[float] = [ 1, 2, 5, 10, 25, 50, 100, 200, 500, 1000 ]

def main(input_change: int):
    monedas: dict[str, int] = vuelto(input_change)
    imprimir_cambio(monedas)

def vuelto(A_Devolver: float) -> dict[str, int]:
    monedas: dict[str, int] = {}

    while A_Devolver > 0:
        ret_moneda: int = buscar_moneda(A_Devolver)
        if ret_moneda is not None:
            A_Devolver -= ret_moneda
            try:
                monedas[str(ret_moneda)] += 1
            except KeyError:
                monedas.update( { str(ret_moneda): 1 } )

    return monedas

## Buscamos la minima cantidad de monedas (menor cantidad, mayor valor)
def buscar_moneda(Cambio: int) -> int:
    i: int = 0

    Monedas_Para_Vuelto.reverse()

    while True:
        if Cambio >= Monedas_Para_Vuelto[i]:
            return Monedas_Para_Vuelto[i]

        i += 1

def imprimir_cambio(Cambios: dict[str, int]) -> None:
    cantidad_monedas: int = 0
    for Cambio in Cambios:
        print(f"${Cambio} :: [{Cambios[Cambio]}]")
        cantidad_monedas += Cambios[Cambio]
    print(f"Se requiero {cantidad_monedas} de monedas")

if __name__ == "__main__":
    main(int(sys.argv[1]))
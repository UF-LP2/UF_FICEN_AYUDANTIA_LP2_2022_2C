Monedas_Para_Vuelto: list[float] = [ 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.25 ]

def main():
    vuelto_: float = float(input("Vuelto a devolver => "))

    monedas: dict[str, int] = vuelto(vuelto_)
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
                monedas.update({ str(ret_moneda): 1 })
    return monedas

def buscar_moneda(Cambio: int) -> int:
    i: int = 0

    while True:
        if Cambio >= Monedas_Para_Vuelto[i]:
            return Monedas_Para_Vuelto[i]

        i += 1

    return None

def imprimir_cambio(Cambios: dict[str, int]) -> None:
    cantidad_monedas: int = 0
    for Cambio in Cambios:
        print(f"${Cambio} :: [{Cambios[Cambio]}]")
        cantidad_monedas += Cambios[Cambio]
    print(f"Se requiero {cantidad_monedas} de monedas")

if __name__ == "__main__":
    main()
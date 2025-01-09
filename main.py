

def zapytajODrzewa(nazwaGminy: str, listaTypowDrzew: list[str]) -> list[int]:
    print(f"Podaj ilość drzew w gminie {nazwaGminy}")

    ilosciDrzew = []

    for typDrzewa in listaTypowDrzew:
        iloscDrzew = int(input(f"Podaj ilość drzew typu {typDrzewa}: "))
        ilosciDrzew.append(iloscDrzew)

    return ilosciDrzew


def zapytajOGmine(listaGmin: list[str], listaTypowDrzew: list[str]) -> tuple[int, int]:
    sumaBrzoz = 0
    sumaWszystkichDrzew = 0

    for gmina in listaGmin:
        ilosciDrzew = zapytajODrzewa(gmina, listaTypowDrzew)

        textDrzew = ''
        for typDrzewa in listaTypowDrzew:
            textDrzew += f"{typDrzewa}: {
                ilosciDrzew[listaTypowDrzew.index(typDrzewa)]}\n"

        print(f"Gmina: {gmina}\n ilości drzew: {textDrzew}")

        sumaBrzoz += ilosciDrzew[0]
        sumaWszystkichDrzew += sum(ilosciDrzew)

    return sumaBrzoz, sumaWszystkichDrzew


def main():
    listaGmin = ["Gmina1", "Gmina2"]
    listaTypowDrzew = ["Brzoza", "Drzewo2"]

    sumaBrzoz, sumaWszystkichDrzew = zapytajOGmine(listaGmin, listaTypowDrzew)

    print(f"Suma brzóz: {sumaBrzoz}")
    print(f"Suma wszystkich drzew: {sumaWszystkichDrzew}")

    if int(sumaBrzoz / sumaWszystkichDrzew * 100) >= 80:
        print("Za dużo brzóz!")

        ileDrzewTrzebaDosadzic = (
            int(sumaBrzoz / 79 * 100) - sumaWszystkichDrzew) * 4

        print(f"Trzeba dosadzić {ileDrzewTrzebaDosadzic} innych drzew")
    else:
        print("Wszystko w porządku")


main()

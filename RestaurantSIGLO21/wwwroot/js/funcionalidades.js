const items = document.getElementById("items")
const templateCard = document.getElementById("template-card").content


document.addEventListener("DOMContentLoad", () => {
    fetchData()
})


const fetchData = async () => {
    try {
        const res = await fetch("http://localhost:8080/api/platos")
        const data = await res.json()
        console.log(data)
    } catch (error) {
        console.log(error)
    }
}

const pintarCard = data => {
    data.forEach(producto => {
        templateCard.querySelector('h5').textContent = producto.descripcion

        const clone = templateCard.cloneNode(true)
        fragment.appendChild(clone)
    })
    items.appendChild(fragment)

}
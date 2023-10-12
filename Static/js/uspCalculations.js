const krPerDayString = ' kr./md';
const multiUspSelectedClass = ' MainUspBlock__Selected';

let sliderElement = document.querySelector('.UspPage__Slider');
let sliderValue = document.querySelector('.UspCalculationPage__EmployeesNumber');
let summarizedPrice = document.querySelector('.UspCalculationPage_SummarizedPrice');
let pricePerOneEmployeeElement = document.querySelector('#PricePerOneEmployee');
let optionalUspBlocks = document.querySelectorAll('.UspCalculationPage__BottomUspBlocksContainer .MainUspBlock__Container');
let optionalUspPrice = document.querySelector('#UspOptionPrice');
let optionalUspPriceContainer = document.querySelector('.UspCalculationPage__AdditionalOptionContainer');

sliderElement.addEventListener("input", (event) => {
    sliderValue.textContent = event.target.value;
    let pricePerOneEmployee = parseInt(pricePerOneEmployeeElement.innerHTML);
    summarizedPrice.textContent = (event.target.value * pricePerOneEmployee) + krPerDayString;
})


optionalUspBlocks.forEach((uspBlock) => {
    uspBlock.addEventListener("click", () => {
        uspBlock.className = uspBlock.className + ' MainUspBlock__Selected';
        let findUspBlockPrice = uspBlock.getElementsByClassName('UspBlock__PriceValue');
        let uspBlockPrice = findUspBlockPrice[0].value;
        optionalUspPrice.textContent = uspBlockPrice + krPerDayString;
        optionalUspPriceContainer.style.display = 'block';
        let pricePerOneEmployee = parseInt(pricePerOneEmployeeElement.innerHTML);
        pricePerOneEmployeeElement.textContent = (parseInt(uspBlockPrice) + pricePerOneEmployee).toString();
    })
})

function test123(){
    let stUspOption = document.querySelector('.MainUspBlock__Container2 #UspBlock__OptionPrice');
    console.log(stUspOption.value)
}

        // Sample order data (this would typically come from your cart or backend)
        const orderItems = [
            { id: 1, name: "Hot Cappuccino", price: 45000, quantity: 2, image: "img/menu-item-1.jpg" },
            { id: 2, name: "Iced Americano", price: 45000, quantity: 1, image: "img/menu-item-6.jpg" }
        ];

        function displayOrderItems() {
            const orderItemsContainer = document.getElementById('order-items');
            let totalAmount = 0;

            orderItems.forEach((item, index) => {
                const itemTotal = item.price * item.quantity;
                totalAmount += itemTotal;

                const itemHtml = `
                    <div class="order-item">
                        <img src="${item.image}" alt="${item.name}">
                        <div class="item-details">
                            <div class="item-name">${index + 1}. ${item.name}</div>
                            <div class="item-price">${formatCurrency(item.price)} x ${item.quantity}</div>
                            <div class="item-total">Total: ${formatCurrency(itemTotal)}</div>
                        </div>
                    </div>
                `;
                orderItemsContainer.innerHTML += itemHtml;
            });

            document.getElementById('total-amount').textContent = formatCurrency(totalAmount);
        }

        function formatCurrency(amount) {
            return new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(amount);
        }

        function goToHomepage() {
            // Replace with your actual homepage URL
            window.location.href = 'index.html';
        }

        function processPayment() {
            // Implement your payment processing logic here
            alert('Processing payment... (This is a placeholder)');
        }

        // Initialize the page
        displayOrderItems();
    
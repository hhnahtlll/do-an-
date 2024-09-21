    // Lấy các phần tử cần thiết
    const addToCartButtons = document.querySelectorAll('.add-to-cart');
    const cartItems = document.querySelector('.cart-items');
    const cartTotalElement = document.querySelector('.cart-total-price');
    
    // Hàm thêm sản phẩm vào giỏ hàng
    function addToCart(item) {
      // Tạo một hàng mới cho sản phẩm
      const cartRow = document.createElement('div');
      cartRow.classList.add('cart-row');
      cartRow.innerHTML = `
        <div class="cart-item cart-column">
          <img class="cart-item-image" src="${item.image}" width="100" height="100">
          <span class="cart-item-title">${item.name}</span>
        </div>
        <span class="cart-price cart-column">${item.price.toLocaleString()} VND</span>
        <div class="cart-quantity cart-column">
          <input class="cart-quantity-input" type="number" value="1" min="1" data-price="${item.price}">
          <button class="btn btn-danger remove-item" type="button">Xóa</button>
        </div>
      `;
      cartItems.appendChild(cartRow);
    
      // Cập nhật tổng tiền
      updateCartTotal();
    }
    
    // Hàm cập nhật tổng tiền
    function updateCartTotal() {
      let total = 0;
      const cartRows = cartItems.querySelectorAll('.cart-row');
      cartRows.forEach(row => {
        const priceElement = row.querySelector('.cart-price');
        const price = parseFloat(priceElement.textContent.replace(' VND', ''));
        const quantityElement = row.querySelector('.cart-quantity-input');
        const quantity = parseInt(quantityElement.value);
        total += price * quantity * 1000;
      });
      cartTotalElement.textContent = total.toLocaleString() + ' VND';
    }
    
    // Hàm xóa sản phẩm khỏi giỏ hàng
    function removeItem(button) {
      button.closest('.cart-row').remove();
      updateCartTotal();
    }
    
    // Xử lý sự kiện click vào nút "Thêm"
    addToCartButtons.forEach(button => {
      button.addEventListener('click', () => {
        const itemName = button.dataset.name;
        const itemPrice = button.closest('.tm-menu-item').querySelector('.text-white p').textContent.replace(' VND', '');
        const itemImage = button.closest('.tm-menu-item').querySelector('img').src;
        addToCart({ name: itemName, price: itemPrice, image: itemImage });
      });
    });
    
    // Xử lý sự kiện click vào nút "Xóa"
    cartItems.addEventListener('click', event => {
      if (event.target.classList.contains('remove-item')) {
        removeItem(event.target);
      }
    });
    
    // Xử lý sự kiện thay đổi số lượng
    cartItems.addEventListener('change', event => {
      if (event.target.classList.contains('cart-quantity-input')) {
        updateCartTotal();
      }
    });
    
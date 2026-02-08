import Navbar from "../Layout/Navbar";
import Footer from "../Layout/Footer";
import "../../Style/Pages/Product.css";

const Product = () => {
  return (
    <div className="product-page">
      <Navbar scrl={true}/>

      <main className="product-content">
        <div className="product-container">
          {/* Product Image */}
          <div className="product-image">
            <img
              src="https://via.placeholder.com/500"
              alt="Product"
            />
          </div>

          {/* Product Details */}
          <div className="product-details">
            <h1 className="product-title">Product Name</h1>
            <p className="product-description">
              This is a placeholder description for the product. It explains features, benefits, and other key details.
            </p>
            <p className="product-price">$99.99</p>

            <div className="product-actions">
              <label>
                Quantity:
                <input type="number" min="1" defaultValue="1" />
              </label>
              <button className="add-to-cart">Add to Cart</button>
            </div>
          </div>
        </div>
      </main>

      <Footer />
    </div>
  );
};

export default Product;

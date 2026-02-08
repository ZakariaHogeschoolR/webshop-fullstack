import "../../Style/Pages/Features.css";
import Navbar from "../../public/Layout/Navbar";
import Footer from "../../public/Layout/Footer";
const Features = () => {
  return (
    <>
        <Navbar scrl={true}/>
            <section className="features-section">
                <div className="features-container">
                    <div className="feature-card">
                    <div className="feature-icon">🚀</div>
                    <h3 className="feature-title">Fast Delivery</h3>
                    <p className="feature-desc">
                        Get your products delivered in record time with our lightning-fast shipping.
                    </p>
                    </div>

                    <div className="feature-card">
                    <div className="feature-icon">💎</div>
                    <h3 className="feature-title">Premium Quality</h3>
                    <p className="feature-desc">
                        We ensure top-notch quality for every item in our store.
                    </p>
                    </div>

                    <div className="feature-card">
                    <div className="feature-icon">🔒</div>
                    <h3 className="feature-title">Secure Payments</h3>
                    <p className="feature-desc">
                        Your transactions are safe and fully encrypted.
                    </p>
                    </div>

                    <div className="feature-card">
                    <div className="feature-icon">🤝</div>
                    <h3 className="feature-title">Customer Support</h3>
                    <p className="feature-desc">
                        24/7 assistance to help you with any questions or concerns.
                    </p>
                    </div>
                </div>
            </section>
        <Footer/>
    </>
  );
};

export default Features;

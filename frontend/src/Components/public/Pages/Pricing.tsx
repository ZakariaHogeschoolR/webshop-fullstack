import Navbar from "../Layout/Navbar";
import Footer from "../Layout/Footer";
import "../../Style/Pages/Pricing.css";

const Pricing = () => {
  return (
    <div className="pricing-page">
      <Navbar scrl={true}/>

      <main className="pricing-content">
        <h1 className="pricing-title">Our Plans</h1>
        <p className="pricing-subtitle">
          Choose the plan that suits your needs. No hidden fees.
        </p>

        <div className="pricing-cards">
          {/* Basic Plan */}
          <div className="pricing-card">
            <h2 className="plan-name">Basic</h2>
            <p className="plan-price">$9<span>/mo</span></p>
            <ul className="plan-features">
              <li>1 Product</li>
              <li>Email Support</li>
              <li>Basic Analytics</li>
            </ul>
            <button className="plan-btn">Get Started</button>
          </div>

          {/* Pro Plan */}
          <div className="pricing-card popular">
            <h2 className="plan-name">Pro</h2>
            <p className="plan-price">$29<span>/mo</span></p>
            <ul className="plan-features">
              <li>10 Products</li>
              <li>Priority Support</li>
              <li>Advanced Analytics</li>
            </ul>
            <button className="plan-btn">Get Started</button>
          </div>

          {/* Enterprise Plan */}
          <div className="pricing-card">
            <h2 className="plan-name">Enterprise</h2>
            <p className="plan-price">$99<span>/mo</span></p>
            <ul className="plan-features">
              <li>Unlimited Products</li>
              <li>Dedicated Support</li>
              <li>Custom Analytics</li>
            </ul>
            <button className="plan-btn">Get Started</button>
          </div>
        </div>
      </main>

      <Footer />
    </div>
  );
};

export default Pricing;

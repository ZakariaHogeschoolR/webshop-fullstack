import Navbar from "../Layout/Navbar";
import Footer from "../Layout/Footer";
import "../../Style/Pages/About.css";

const About = () => {
  return (
    <div className="about-root">
      <Navbar scrl={true} />

      {/* HERO */}
      <section className="about-hero">
        <h1>
          We don’t just build products.  
          <span>We design experiences.</span>
        </h1>
        <p>
          A product-driven team focused on clarity, performance, and detail.
        </p>
      </section>

      {/* SPLIT STORY */}
      <section className="about-split">
        <div className="split-text">
          <h2>Why we exist</h2>
          <p>
            Most products are overcomplicated.  
            We believe great software should feel obvious, fast, and beautiful.
          </p>
          <p>
            Every decision we make is driven by usability, craftsmanship, and long-term thinking.
          </p>
        </div>

        <div className="split-visual">
          <div className="visual-block"></div>
        </div>
      </section>

      {/* VALUES */}
      <section className="about-values">
        <div className="value">
          <h3>Clarity</h3>
          <p>No noise. No confusion. Only what matters.</p>
        </div>
        <div className="value">
          <h3>Craft</h3>
          <p>Details aren’t extra — they *are* the product.</p>
        </div>
        <div className="value">
          <h3>Speed</h3>
          <p>Fast products feel respectful of your time.</p>
        </div>
      </section>

      <Footer />
    </div>
  );
};

export default About;

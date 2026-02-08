import '../../Style/Home/Home.css';

const Home = () => {
  return (
    <main className="home-container">

      {/* HERO SECTION */}
      <section className="home-hero">
        <div className="hero-content">
          <h1>Next-Level SaaS, Inspired by Culture</h1>
          <p>Seamlessly combining precision, elegance, and a touch of Moroccan-Chinese aesthetics.</p>
          <a href="/signup" className="hero-cta">Get Started</a>
        </div>
      </section>

      {/* FEATURES SECTION */}
      <section className="home-features">
        <h2>Why Choose Us</h2>
        <div className="features-grid">
          <div className="feature-card">
            <h3>Reliable</h3>
            <p>Our platform guarantees 99.9% uptime, keeping your SaaS running smoothly.</p>
          </div>
          <div className="feature-card">
            <h3>Secure</h3>
            <p>Advanced security measures ensure your data is safe and private at all times.</p>
          </div>
          <div className="feature-card">
            <h3>Elegant</h3>
            <p>Beautiful design inspired by Moroccan and Chinese aesthetics for a refined experience.</p>
          </div>
        </div>
      </section>

      {/* CTA SECTION */}
      <section className="home-cta-section">
        <h2>Ready to elevate your workflow?</h2>
        <a href="/signup" className="cta-button">Get Started</a>
      </section>

    </main>
  );
}

export default Home;
